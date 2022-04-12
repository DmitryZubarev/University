using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class DeletingForm : Form
    {
        string con;

        void LoadTree(TreeView tv)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Faculties", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode f = new TreeNode(reader["FacultyName"].ToString());
                    tv.Nodes.Add(f);
                    LoadCourse((int)reader["id"], f);
                }

                connection.Close();
            }
        }

        void LoadCourse(int facultyId, TreeNode faculty)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"select * from Courses
                                                      where FacultyId=@facultyId",
                                                      connection);
                command.Parameters.AddWithValue("facultyId", facultyId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode c = new TreeNode(reader["CourseName"].ToString());
                    faculty.Nodes.Add(c);
                    LoadGroups((int)reader["id"], c);
                }

                connection.Close();
            }
        }

        void LoadGroups(int id, TreeNode course)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"select * from Groups
                                                      where CourseId=@courseId",
                                                      connection);
                command.Parameters.AddWithValue("courseId", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode c = new TreeNode(reader["GroupName"].ToString());
                    course.Nodes.Add(c);
                }

                connection.Close();
            }
        }

        public DeletingForm(string connectionString)
        {
            InitializeComponent();
            con = connectionString;
        }

        private void DeletingForm_Load(object sender, EventArgs e)
        {
            LoadTree(treeViewDeleting);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeViewDeleting.SelectedNode != null)
            {
                using (SqlConnection sqlConnection = new SqlConnection(con))
                {
                    sqlConnection.Open();
                    SqlCommand cmd;

                    switch (treeViewDeleting.SelectedNode.Level)
                    {
                        case 0: //Faculty
                            cmd = new SqlCommand(@"select id
                                                   from Faculties
                                                   where FacultyName=@Name",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("Name", treeViewDeleting.SelectedNode.Text);
                            int idFaculty = (int)cmd.ExecuteScalar();

                            cmd = new SqlCommand(@"select id
                                           from Courses
                                           where FacultyId=" + Convert.ToString(idFaculty),
                                           sqlConnection);
                            SqlDataReader reader = cmd.ExecuteReader();
                            List<int> idCourses = new List<int>();
                            while (reader.Read())
                            {
                                idCourses.Add((int)reader["id"]);
                            }
                            reader.Close();

                            foreach (int course in idCourses)
                            {
                                cmd = new SqlCommand($"delete from Groups where CourseId={course}", sqlConnection);
                                cmd.ExecuteNonQuery();
                            }
                            cmd = new SqlCommand($"delete from Courses where FacultyId={idFaculty}", sqlConnection);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand($"delete from Faculties where id={idFaculty}", sqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                        case 1: //Course
                            cmd = new SqlCommand(@"select id
                                                   from Courses
                                                   where CourseName=@Name",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("Name", treeViewDeleting.SelectedNode.Text);
                            int idCourse = (int)cmd.ExecuteScalar();

                            cmd = new SqlCommand($"delete from Groups where CourseId={idCourse}", sqlConnection);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand($"delete from Courses where id={idCourse}", sqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                        case 2: //Group
                            cmd = new SqlCommand(@"select id
                                                   from Groups
                                                   where GroupName=@Name",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("Name", treeViewDeleting.SelectedNode.Text);
                            int idGroup = (int)cmd.ExecuteScalar();
                            cmd = new SqlCommand($"delete from Groups where id={idGroup}", sqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                    }
                    
                    sqlConnection.Close();
                }
                treeViewDeleting.SelectedNode.Remove();
            }
            else { MessageBox.Show("Выбери элемент, жи есть"); }
        }
    }
}
