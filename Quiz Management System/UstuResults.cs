
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
    public partial class UstuResults : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");

        public UstuResults()
        {
            InitializeComponent();
        }
        private void FilterCombo()
        {
            SqlCommand query = new SqlCommand("SELECT stu.Name, stu.Surname, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss INNER JOIN Students stu ON ss.Student_id=stu.Id INNER JOIN Groups g ON stu.Group_id=g.Id INNER JOIN Subjects sub ON ss.Subject_id=sub.Id WHERE sub.Name LIKE '%" + comboBox1.Text + "'", con);
            SqlDataAdapter dat2 = new SqlDataAdapter();
            DataTable dtbl2 = new DataTable();
            dat2.SelectCommand = query;
            dtbl2.Clear();
            dat2.Fill(dtbl2);
            resultDGV.DataSource = dtbl2;

        }
        private void FilterComboGroup()
        {
            SqlCommand query = new SqlCommand("SELECT stu.Name, stu.Surname, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss INNER JOIN Students stu ON ss.Student_id=stu.Id INNER JOIN Groups g ON stu.Group_id=g.Id INNER JOIN Subjects sub ON ss.Subject_id=sub.Id WHERE g.Group_no LIKE '%" + comboBox2.Text + "' AND sub.Name LIKE '%" + comboBox1.Text+ "'", con);
            SqlDataAdapter dat4 = new SqlDataAdapter();
            DataTable dtbl4 = new DataTable();
            dat4.SelectCommand = query;
            dtbl4.Clear();
            dat4.Fill(dtbl4);
            resultDGV.DataSource = dtbl4;

        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT stu.Name, stu.Surname, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss INNER JOIN Students stu ON ss.Student_id=stu.Id INNER JOIN Groups g ON stu.Group_id=g.Id INNER JOIN Subjects sub ON ss.Subject_id=sub.Id";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    resultDGV.DataSource = dt;
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
        private void ComboLoadGroup()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
            SqlCommand cmd;
            comboBox2.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Group_no FROM Groups";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dtbl);


            foreach (DataRow dr in dtbl.Rows)
            {
                comboBox2.Items.Add(dr["Group_no"].ToString());

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void UstuResults_Load(object sender, EventArgs e)
        {
            ComboLoad();
            LoadData();
            ComboLoadGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterComboGroup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
