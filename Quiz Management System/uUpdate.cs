
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
    public partial class uUpdate : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");

        public uUpdate()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT q.Id Question_id, s.Name Subject, q.Content, q.Answer1, q.Answer2, q.Answer3, q.Answer4, q.CorrectAnswer FROM Questions q INNER JOIN Subjects s ON q.Subject_id = s.Id ";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                if (dtt.Rows.Count > 0)
                {
                    updateDGV.DataSource = dtt;
                }
            }
        }
        private void FilterCombo()
        {
            SqlCommand query = new SqlCommand("SELECT q.Id Question_id, s.Name Subject, q.Content, q.Answer1, q.Answer2, q.Answer3, q.Answer4, q.CorrectAnswer FROM Questions q INNER JOIN Subjects s ON q.Subject_id = s.Id WHERE s.Name LIKE '%" + comboBox1.Text + "'", con);
            SqlDataAdapter dat2 = new SqlDataAdapter();
            DataTable dtbl2 = new DataTable();
            dat2.SelectCommand = query;
            dtbl2.Clear();
            dat2.Fill(dtbl2);
            updateDGV.DataSource = dtbl2;

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
        private void uUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
            ComboLoad();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("UPDATE Questions SET Content=@content, Answer1=@ans1, Answer2=@ans2, Answer3=@ans3, Answer4=@ans4, CorrectAnswer=@cr WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("id", label10.Text);
            cmd.Parameters.AddWithValue("content", richTextBox1.Text);
            cmd.Parameters.AddWithValue("ans1", textBox2.Text);
            cmd.Parameters.AddWithValue("ans2", textBox3.Text);
            cmd.Parameters.AddWithValue("ans3", textBox4.Text);
            cmd.Parameters.AddWithValue("ans4", textBox5.Text);
            cmd.Parameters.AddWithValue("cr", textBox6.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
            FilterCombo();
        }

        private void updateDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = updateDGV.Rows[index];
            label10.Text = selectedRow.Cells[0].Value.ToString();
            richTextBox1.Text = selectedRow.Cells[2].Value.ToString();
            textBox2.Text = selectedRow.Cells[3].Value.ToString();
            textBox3.Text = selectedRow.Cells[4].Value.ToString();
            textBox4.Text = selectedRow.Cells[5].Value.ToString();
            textBox5.Text = selectedRow.Cells[6].Value.ToString();
            textBox6.Text = selectedRow.Cells[7].Value.ToString();
        }
    }
}
