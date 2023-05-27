using ExcelDataReader;
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
    public partial class NewSubject : UserControl
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd;
        public NewSubject()
        {
            InitializeComponent();
        }

        private void addSubBtn_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Don't keep any textbox blank!");
                return;
            }

            string query = "INSERT INTO Subjects(Name)" +
                "VALUES (@Name)";

            con.Open();

            scmd = new SqlCommand(query, con);

            //add parameters



            scmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            scmd.Parameters["@Name"].Value = addnewsubtxt.Text;

            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful");

        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(addnewsubtxt.Text))

                return false;
            else return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            filePath.Text = dlg.FileName;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(filePath.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO Lecture(Data, Extension, FileName, Subject_id)" +
                    "VALUES(@data, @extn, @name, @sub_id)";

                using (SqlConnection cn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@sub_id", SqlDbType.Int).Value = subLec.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();


                }

            }
        }

        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        }

        private void NewSubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {

                string query1 = "SELECT * FROM Subjects";
                SqlDataAdapter adp1 = new SqlDataAdapter(query1, cn);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    dgvSub.DataSource = dt1;
                }



                string query = "SELECT le.Id, le.FileName, le.Extension, sub.Name FROM Lecture le inner join Subjects sub on sub.Id = le.Subject_id  ";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvDocuments.DataSource = dt;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDocuments.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;

                OpenFile(id);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK )
                {
                    excelfileName.Text = ofd.FileName;
                }
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;

            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(excelfileName.Text);
                xlworksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                dataGridView1.ColumnCount=xlrange.Columns.Count;
                int i=0;
                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)        
                {
                    i++;
                    dataGridView1.Rows.Add(i, xlrange.Cells[xlrow, 1].ToString(), xlrange.Cells[xlrow, 2].ToString(), xlrange.Cells[xlrow, 3].ToString(), xlrange.Cells[xlrow, 4].ToString(), xlrange.Cells[xlrow, 5].ToString(), xlrange.Cells[xlrow, 6].ToString());
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

            
            

            
        }

        private void dgvDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
