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
        //public string stuName { get; set; }
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd;

        public uQuiz()
        {
            InitializeComponent();
        }
        int i = 0, point = 0, questionCount = 0;
        List<string> answers;
        List<string> variantA;
        List<string> variantB;
        List<string> variantC;
        List<string> variantD;
        List<string> content;
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
            lblEmail.Text = Properties.Settings.Default.studentEmail;
            loadSubjects();
        }
        private void loadSubjects()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True"))
                {
                    string strSQL = "SELECT * FROM Subjects";
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, con))
                    {
                        con.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        comboBox1.DataSource = ds.Tables[0];
                        comboBox1.DisplayMember = "Name";
                        comboBox1.ValueMember = "Id";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RandomData()
        {
            answers = new List<string>();
            variantA = new List<string>();
            variantB = new List<string>();
            variantC = new List<string>();
            variantD = new List<string>();
            content = new List<string>();
            string connectionString = "Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True";

            string query1 = "SELECT q.Content,q.Answer1,q.Answer2,q.Answer3,q.Answer4,q.CorrectAnswer FROM Questions q INNER JOIN Subjects sub ON q.Subject_id=sub.Id WHERE q.Subject_id = @sid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue(@"sid", comboBox1.SelectedValue);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string question = reader["Content"].ToString();
                        string data1 = reader["Answer1"].ToString();
                        string data2 = reader["Answer2"].ToString();
                        string data3 = reader["Answer3"].ToString();
                        string data4 = reader["Answer4"].ToString();
                        string answer = reader["CorrectAnswer"].ToString();

                        content.Add(question);
                        variantA.Add(data1);
                        variantB.Add(data2);
                        variantC.Add(data3);
                        variantD.Add(data4);
                        answers.Add(answer);
                    }

                    reader.Close();
                }
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryCount = "SELECT COUNT(ID) FROM Questions WHERE Subject_id = @sid";
                using (SqlCommand command = new SqlCommand(queryCount, connection))
                {
                    command.Parameters.AddWithValue(@"sid", comboBox1.SelectedValue);

                    questionCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }


            textBox2.Text = content[i];
            radioButton1.Text = variantA[i];
            radioButton2.Text = variantB[i];
            radioButton3.Text = variantC[i];
            radioButton4.Text = variantD[i];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        A:
            if (i < questionCount)
            {
                if (radioButton1.Checked && answers[i] == radioButton1.Text)
                {
                    point++;
                }
                else if (radioButton2.Checked && answers[i] == radioButton2.Text)
                {
                    point++;
                }
                else if (radioButton3.Checked && answers[i] == radioButton3.Text)
                {
                    point++;
                }
                else if (radioButton4.Checked && answers[i] == radioButton4.Text)
                {
                    point++;
                }
                lblPoint.Text = "Xal : " + point;
                i++;

                if (i == questionCount)
                    goto A;
                textBox2.Text = content[i];
                radioButton1.Text = variantA[i];
                radioButton2.Text = variantB[i];
                radioButton3.Text = variantC[i];
                radioButton4.Text = variantD[i];

            }
            else
            {
                MessageBox.Show($"Suallar bitdi. Topladığınız bal:{point}");


                string query = "INSERT INTO SubjectStudent(Student_id, Subject_id, Score) VALUES((SELECT Students.Id from Students where Students.Email like '"+lblEmail.Text+"%'), (SELECT Subjects.Id FROM Subjects WHERE Subjects.Name LIKE '"+comboBox1.Text+"%'), @point)";
                con.Open();
                scmd = new SqlCommand(query, con);

                scmd.Parameters.Add("@point", SqlDbType.Int);
                scmd.Parameters["@point"].Value = point;


                scmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
