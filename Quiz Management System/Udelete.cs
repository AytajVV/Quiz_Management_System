using System;
using System.Collections;
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
    public partial class Udelete : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");


        public Udelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT q.Id Question_id, s.Name Subject, q.Content, q.Answer1, q.Answer2, q.Answer3, q.Answer4, q.CorrectAnswer FROM Questions q INNER JOIN Subjects s ON q.Subject_id = s.Id WHERE s.Id=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            deleteDGV.DataSource= dtb;
            cmd.ExecuteNonQuery();

            

            con.Close();

        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }
        private void LoadData()
        {
            using(SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT q.Id Question_id, s.Name Subject, q.Content, q.Answer1, q.Answer2, q.Answer3, q.Answer4, q.CorrectAnswer FROM Questions q INNER JOIN Subjects s ON q.Subject_id = s.Id ";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    deleteDGV.DataSource = dt;
                }
            }
        }

        private void ComboLoad()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
            SqlCommand cmd;
            comboBox1.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM Subjects";
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

        private void FilterCombo()
        {
            SqlCommand query = new SqlCommand("SELECT q.Id Question_id, s.Name Subject, q.Content, q.Answer1, q.Answer2, q.Answer3, q.Answer4, q.CorrectAnswer FROM Questions q INNER JOIN Subjects s ON q.Subject_id = s.Id WHERE s.Name LIKE '%" + comboBox1.Text + "'", con);
            SqlDataAdapter dat2 = new SqlDataAdapter();
            DataTable dtbl2 = new DataTable();
            dat2.SelectCommand = query;
            dtbl2.Clear();
            dat2.Fill(dtbl2);
            deleteDGV.DataSource = dtbl2;

        }

        private void deleteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Udelete_Load(object sender, EventArgs e)
        {
            LoadData();
            ComboLoad();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE  FROM Questions WHERE Id=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            deleteDGV.DataSource = dtb;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            FilterCombo();

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
