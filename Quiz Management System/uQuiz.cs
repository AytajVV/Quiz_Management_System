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

namespace Quiz_Management_System
{
    public partial class uQuiz : UserControl
    {
        public string stName { get; set; }
        public uQuiz()
        {
            InitializeComponent();
        }
        private void ComboLoad()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
            SqlCommand cmd;
            comboBox1.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT sub.Name FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dtbl);


            foreach (DataRow dr in dtbl.Rows)
            {
                comboBox1.Items.Add(dr["Name"].ToString());

            }
            con.Close();
        }
        private void uQuiz_Load(object sender, EventArgs e)
        {
            ComboLoad();
        }
                                                                                                       
        private void RandomData()
        {
            string connectionString = "Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True";
            string query = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%"+comboBox1.Text+"'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label3.Text = randomData;
                    }

                    reader.Close();
                }
            }



            string query1 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label3.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton1.Text = data;
                    }

                    reader.Close();
                }
            }



            string query2 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label3.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton2.Text = data;
                    }

                    reader.Close();
                }
            }



            string query3 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label3.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton3.Text = data;
                    }

                    reader.Close();
                }
            }



            string query4 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label3.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query4, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton4.Text = data;
                    }

                    reader.Close();
                }
            }

            //=================================================================================================================================


            string Mainquery2 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery2, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label5.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query5 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label5.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query5, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton5.Text = data;
                    }

                    reader.Close();
                }
            }



            string query6 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label5.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query6, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton6.Text = data;
                    }

                    reader.Close();
                }
            }



            string query7 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label5.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query7, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton7.Text = data;
                    }

                    reader.Close();
                }
            }



            string query8 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label5.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query8, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton8.Text = data;
                    }

                    reader.Close();
                }
            }








            //=================================================================================================================================


            string Mainquery3 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery3, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label7.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query9 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label7.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query9, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton9.Text = data;
                    }

                    reader.Close();
                }
            }



            string query10 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label7.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query10, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton10.Text = data;
                    }

                    reader.Close();
                }
            }



            string query11 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label7.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query11, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton11.Text = data;
                    }

                    reader.Close();
                }
            }



            string query12 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label7.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query12, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton12.Text = data;
                    }

                    reader.Close();
                }
            }



            //===========================================================================================================================



            string Mainquery4 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery4, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label9.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query13 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label9.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query13, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton13.Text = data;
                    }

                    reader.Close();
                }
            }



            string query14 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label9.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query14, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton14.Text = data;
                    }

                    reader.Close();
                }
            }



            string query15 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label9.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query15, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton15.Text = data;
                    }

                    reader.Close();
                }
            }



            string query16 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label9.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query16, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton16.Text = data;
                    }

                    reader.Close();
                }
            }





            ////===========================================================================================================================


            string Mainquery5 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery5, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label11.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query17 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label11.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query17, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton17.Text = data;
                    }

                    reader.Close();
                }
            }



            string query18 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label11.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query18, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton18.Text = data;
                    }

                    reader.Close();
                }
            }



            string query19 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label11.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query19, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton19.Text = data;
                    }

                    reader.Close();
                }
            }



            string query20 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label11.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query20, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton20.Text = data;
                    }

                    reader.Close();
                }
            }






            ////===========================================================================================================================


            string Mainquery6 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery6, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label13.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query21 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label13.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query21, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton21.Text = data;
                    }

                    reader.Close();
                }
            }



            string query22 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label13.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query22, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton22.Text = data;
                    }

                    reader.Close();
                }
            }



            string query23 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label13.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query23, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton23.Text = data;
                    }

                    reader.Close();
                }
            }



            string query24 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label13.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query24, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton24.Text = data;
                    }

                    reader.Close();
                }
            }





            ////===========================================================================================================================


            string Mainquery7 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery7, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label15.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query25 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label15.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query25, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton25.Text = data;
                    }

                    reader.Close();
                }
            }



            string query26 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label15.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query26, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton26.Text = data;
                    }

                    reader.Close();
                }
            }



            string query27 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label15.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query27, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton27.Text = data;
                    }

                    reader.Close();
                }
            }



            string query28 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label15.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query28, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton28.Text = data;
                    }

                    reader.Close();
                }
            }





            ////===========================================================================================================================


            string Mainquery8 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery8, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label17.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query29 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label17.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query29, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton29.Text = data;
                    }

                    reader.Close();
                }
            }



            string query30 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label17.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query30, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton30.Text = data;
                    }

                    reader.Close();
                }
            }



            string query31 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label17.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query31, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton31.Text = data;
                    }

                    reader.Close();
                }
            }



            string query32 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label17.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query32, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton32.Text = data;
                    }

                    reader.Close();
                }
            }



            ////===========================================================================================================================


            string Mainquery9 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery9, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label19.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query33 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label19.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query33, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton33.Text = data;
                    }

                    reader.Close();
                }
            }



            string query34 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label19.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query34, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton34.Text = data;
                    }

                    reader.Close();
                }
            }



            string query35 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label19.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query35, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton35.Text = data;
                    }

                    reader.Close();
                }
            }



            string query36 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label19.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query36, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton36.Text = data;
                    }

                    reader.Close();
                }
            }



            ////===========================================================================================================================


            string Mainquery10 = "SELECT q.Content FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'  ORDER BY NEWID()";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Mainquery10, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string randomData = reader["Content"].ToString();

                        // Update the label in the Windows Forms application
                        label21.Text = randomData;
                    }

                    reader.Close();
                }
            }


            string query37 = "SELECT q.Answer1 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label21.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query37, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer1"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton37.Text = data;
                    }

                    reader.Close();
                }
            }



            string query38 = "SELECT q.Answer2 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label21.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query38, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer2"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton38.Text = data;
                    }

                    reader.Close();
                }
            }



            string query39 = "SELECT q.Answer3 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label21.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query39, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer3"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton39.Text = data;
                    }

                    reader.Close();
                }
            }



            string query40 = "SELECT q.Answer4 FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Content LIKE '%" + label21.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query40, connection))
                {
                    // Execute the query and retrieve the result
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you want to retrieve a specific column, replace "YourColumn" with the actual column name
                        string data = reader["Answer4"].ToString();

                        // Update the label in the Windows Forms application
                        radioButton40.Text = data;
                    }

                    reader.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //panel2.Visible = false;
            //panel3.Visible = false;
            //panel4.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            //panel1.Visible = false;
            //panel1.Visible = false;
            //panel3.Visible = false;
            //panel4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
          
            


        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    panel3.Visible = true;
        //    //panel2.Visible = false;
        //    //panel1.Visible = false;
        //    //panel4.Visible = false;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    panel4.Visible = true;
        //   // panel3.Visible = false;
        //    //panel1.Visible = false;
        //    //panel2.Visible = false;
        //}
    }
}
