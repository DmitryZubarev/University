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
    public partial class UpdatingForm : Form
    {
        string con;

        public UpdatingForm(string connectionString)
        {
            InitializeComponent();
            con = connectionString;
        }

        private void UpdatingForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand(@"select FacultyName
                                                  from Faculties",
                                                  sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxFaculties.Items.Add(Convert.ToString(reader["FacultyName"]));
                }
                reader.Close();

                cmd = new SqlCommand(@"select CourseName
                                       from Courses",
                                       sqlConnection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCourses.Items.Add(Convert.ToString(reader["CourseName"]));
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
            comboBoxFaculties.SelectedItem = comboBoxFaculties.Items[0];
            comboBoxCourses.SelectedItem = comboBoxCourses.Items[0];
            comboBoxGroups.SelectedItem = comboBoxGroups.Items[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPageFaculty":
                    if(textBoxNewFName.Text != "")
                    {
                        string newName = textBoxNewFName.Text;
                        string oldName = Convert.ToString(comboBoxFaculties.SelectedItem);
                        using (SqlConnection sqlConnection = new SqlConnection(con))
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand(@"select id
                                                              from Faculties
                                                              where FacultyName=@Name",
                                                              sqlConnection);
                            cmd.Parameters.AddWithValue("Name", oldName);
                            int id = (int)cmd.ExecuteScalar();
                            cmd = new SqlCommand(@"update Faculties
                                                   set FacultyName=@NewName
                                                   where id=@id",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("NewName", newName);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        textBoxNewFName.Text = "";
                    }
                    else { MessageBox.Show("Введи данные, жи есть"); }
                    break;


                case "tabPageCourse":
                    if (textBoxNewCName.Text != "")
                    {
                        string newName = textBoxNewCName.Text;
                        string oldName = Convert.ToString(comboBoxCourses.SelectedItem);
                        using (SqlConnection sqlConnection = new SqlConnection(con))
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand(@"select id
                                                              from Courses
                                                              where CourseName=@Name",
                                                              sqlConnection);
                            cmd.Parameters.AddWithValue("Name", oldName);
                            int id = (int)cmd.ExecuteScalar();
                            cmd = new SqlCommand(@"update Courses
                                                   set CourseName=@NewName
                                                   where id=@id",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("NewName", newName);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        textBoxNewCName.Text = "";
                    }
                    else { MessageBox.Show("Введи данные, жи есть"); }
                    break;


                case "tabPageGroup":
                    if (textBoxNewGName.Text != "")
                    {
                        string newName = textBoxNewGName.Text;
                        string oldName = Convert.ToString(comboBoxGroups.SelectedItem);
                        using (SqlConnection sqlConnection = new SqlConnection(con))
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand(@"select id
                                                              from Groups
                                                              where GroupName=@Name",
                                                              sqlConnection);
                            cmd.Parameters.AddWithValue("Name", oldName);
                            int id = (int)cmd.ExecuteScalar();
                            cmd = new SqlCommand(@"update Groups
                                                   set GroupName=@NewName
                                                   where id=@id",
                                                   sqlConnection);
                            cmd.Parameters.AddWithValue("NewName", newName);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        textBoxNewGName.Text = "";
                    }
                    else { MessageBox.Show("Введи данные, жи есть"); }
                    break;
            }
        }
    }
}
