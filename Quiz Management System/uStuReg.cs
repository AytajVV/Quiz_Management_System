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
    public partial class uStuReg : UserControl
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd;
        public uStuReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Don't keep any textbox blank!");
                return;
            }

            string query = "INSERT INTO Groups(Group_no, Specialty)" +
                "VALUES (@no, @specialty)";

            con.Open();

            scmd = new SqlCommand(query, con);

            //add parameters



            scmd.Parameters.Add("@no", SqlDbType.NVarChar);
            scmd.Parameters["@no"].Value = textBox1.Text;

            scmd.Parameters.Add("@specialty", SqlDbType.NVarChar);
            scmd.Parameters["@specialty"].Value = textBox2.Text;

            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful");
        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))

                return false;
            else return true;

        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {

                string query1 = "SELECT * FROM Groups";
                SqlDataAdapter adp1 = new SqlDataAdapter(query1, cn);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    groupsDGV.DataSource = dt1;
                }




            }
        }

        private void LoadDataStu()
        {
            using(SqlConnection cn = GetSqlConnection())
            {
                string query3 = "SELECT g.Group_no, s.Name, s.Surname, s.Age, s.Email, s.Password, g.Specialty FROM Students s INNER JOIN Groups g ON s.Group_id=g.Id";
                SqlDataAdapter adp3 = new SqlDataAdapter(query3, cn);
                DataTable dt3 = new DataTable();
                adp3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    newstuDGV.DataSource = dt3;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void uStuReg_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataStu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Students(Group_id, Name, Surname, Age, Email, Password)" +
                "VALUES (@groupID, @name, @surname, @age, @email, @password)";

            con.Open();

            scmd = new SqlCommand(query, con);

            //add parameters



            scmd.Parameters.Add("@groupID", SqlDbType.Int);
            scmd.Parameters["@groupID"].Value = textBox3.Text;

            scmd.Parameters.Add("@name", SqlDbType.NVarChar);
            scmd.Parameters["@name"].Value = textBox4.Text;

            scmd.Parameters.Add("@surname", SqlDbType.NVarChar);
            scmd.Parameters["@surname"].Value = textBox5.Text;

            scmd.Parameters.Add("@age", SqlDbType.Int);
            scmd.Parameters["@age"].Value = textBox6.Text;

            scmd.Parameters.Add("@email", SqlDbType.NVarChar);
            scmd.Parameters["@email"].Value = textBox7.Text;

            scmd.Parameters.Add("@password", SqlDbType.NVarChar);
            scmd.Parameters["@password"].Value = textBox8.Text;

            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDataStu();
        }
    }
}
