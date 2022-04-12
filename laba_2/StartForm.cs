using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class StartForm : Form
    {
        string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=university;Integrated Security=True";

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

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            LoadTree(treeViewLoad);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddingForm frm = new AddingForm(con);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletingForm frm = new DeletingForm(con);
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatingForm frm = new UpdatingForm(con);
            frm.ShowDialog();
        }

        private void btnReloadTree_Click(object sender, EventArgs e)
        {
            treeViewLoad.Nodes.Clear();
            LoadTree(treeViewLoad);
        }
    }
}
