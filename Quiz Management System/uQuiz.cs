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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomData();

        }
    }
}
