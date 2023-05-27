
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Management_System
{
    public partial class uLecture : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");

        public uLecture()
        {
            InitializeComponent();
        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT le.Id, le.FileName, le.Extension, sub.Name FROM Lecture le inner join Subjects sub on sub.Id = le.Subject_id  ";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
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
            cmd.CommandText = "SELECT sub.Name FROM Lecture l INNER JOIN Subjects sub ON l.Subject_id=sub.Id";
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
            SqlCommand query = new SqlCommand("SELECT le.Id, le.FileName, le.Extension, sub.Name FROM Lecture le inner join Subjects sub on sub.Id = le.Subject_id WHERE sub.Name LIKE '%" + comboBox1.Text + "'", con);
            SqlDataAdapter dat2 = new SqlDataAdapter();
            DataTable dtbl2 = new DataTable();
            dat2.SelectCommand = query;
            dtbl2.Clear();
            dat2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;

        }
        private void uLecture_Load(object sender, EventArgs e)
        {
            ComboLoad();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT Data, FileName, Extension FROM Lecture WHERE Id = @id ";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["Data"];

                    var extn = reader["Extension"].ToString();

                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);

                    //System.Diagnostics.Process.Start(newFileName);
                    Process.Start(new ProcessStartInfo { FileName = newFileName, UseShellExecute = true });
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;

                OpenFile(id);
            }
        }
    }
}
