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
    public partial class AddingForm : Form
    {
        string con;

        void ClearFills()
        {
            textBoxNewFaculty.Text = "";
            textBoxNewCourse.Text = "";
            textBoxNewGroup.Text = "";
        }

        public AddingForm(string connectionString)
        {
            InitializeComponent();
            con = connectionString;
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand(@"select FacultyName 
                                                  from Faculties",
                                                  sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                //Put faculties to 2 comboBoxes (page_1 and page_2)
                while (reader.Read())
                {
                    comboBoxFaculties.Items.Add(Convert.ToString(reader["FacultyName"]));
                    comboBoxFaculties2.Items.Add(Convert.ToString(reader["FacultyName"]));
                }
                reader.Close();

                cmd = new SqlCommand(@"select CourseName 
                                       from Courses",
                                       sqlConnection);
                reader = cmd.ExecuteReader();
                //Put courses to 2 comboBoxes (page_2 and page_3)
                while (reader.Read())
                {
                    comboBoxCourses2.Items.Add(Convert.ToString(reader["CourseName"]));
                    comboBoxCourses3.Items.Add(Convert.ToString(reader["CourseName"]));
                }
                reader.Close();

                cmd = new SqlCommand(@"select GroupName 
                                       from Groups",
                                       sqlConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxGroups.Items.Add(Convert.ToString(reader["GroupName"]));
                }
                reader.Close();

                sqlConnection.Close();
            }
        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con)) 
            {
                sqlConnection.Open();
                switch (tabControlAdding.SelectedTab.Name)
                {
                    case "tabPageFaculty":
                        if (textBoxNewFaculty.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand(@"select count(*) 
                                                          from Faculties
                                                          where FacultyName=@Name",
                                                          sqlConnection);
                            cmd.Parameters.AddWithValue("Name", textBoxNewFaculty.Text);
                            if ((int)cmd.ExecuteScalar() == 0)
                            {
                                cmd.Parameters.Clear();
                                cmd = new SqlCommand(@"insert into Faculties
                                                   (FacultyName)
                                                   values (@Name)",
                                                       sqlConnection);
                                cmd.Parameters.AddWithValue("Name", textBoxNewFaculty.Text);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Такой факультет уже существует");
                            }
                        }
                        else { MessageBox.Show("Введи данные, жи есть"); }
                        break;
                    case "tabPageCourse":
                        if (textBoxNewCourse.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand(@"select count(*) 
                                               from Courses
                                               where CourseName=@Name",
                                               sqlConnection);
                            cmd.Parameters.AddWithValue("Name", textBoxNewCourse.Text);
                            if ((int)cmd.ExecuteScalar() == 0)
                            {
                                cmd.Parameters.Clear();
                                cmd = new SqlCommand(@"select id 
                                                   from Faculties
                                                   where FacultyName=@Name",
                                                       sqlConnection);
                                cmd.Parameters.AddWithValue("Name", Convert.ToString(comboBoxFaculties2.SelectedItem));
                                int idFaculty = (int)cmd.ExecuteScalar();
                                cmd = new SqlCommand(@"insert into Courses
                                                   (CourseName, FacultyId)
                                                   values (@Name, @id)",
                                                       sqlConnection);
                                cmd.Parameters.AddWithValue("Name", textBoxNewCourse.Text);
                                cmd.Parameters.AddWithValue("id", idFaculty);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Такой курс уже существует");
                            }
                        }
                        else { MessageBox.Show("Введи данные, жи есть"); }
                        break;
                    case "tabPageGroup":
                        if (textBoxNewGroup.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand(@"select count(*) 
                                               from Groups
                                               where GroupName=@Name",
                                               sqlConnection);
                            cmd.Parameters.AddWithValue("Name", textBoxNewGroup.Text);
                            if ((int)cmd.ExecuteScalar() == 0)
                            {
                                cmd.Parameters.Clear();
                                cmd = new SqlCommand(@"select id 
                                                   from Courses
                                                   where CourseName=@Name",
                                                       sqlConnection);
                                cmd.Parameters.AddWithValue("Name", Convert.ToString(comboBoxCourses3.SelectedItem));
                                int idCourse = (int)cmd.ExecuteScalar();
                                cmd = new SqlCommand(@"insert into Groups
                                                   (GroupName, CourseId)
                                                   values (@Name, @id)",
                                                       sqlConnection);
                                cmd.Parameters.AddWithValue("Name", textBoxNewGroup.Text);
                                cmd.Parameters.AddWithValue("id", idCourse);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Такая группа уже существует");
                            }
                        }
                        else { MessageBox.Show("Введи данные, жи есть"); }
                        break;
                }
                sqlConnection.Close();
                ClearFills();
            }
        }
    }
}
