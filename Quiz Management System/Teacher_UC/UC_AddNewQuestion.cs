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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_Management_System.Teacher_UC
{
    public partial class UC_AddNewQuestion : UserControl
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd;
        public UC_AddNewQuestion()
        {
            InitializeComponent();
        }

        private void addQuesBtn_Click(object sender, EventArgs e)
        {
            //int selectedIndex = selectSubCombo.SelectedIndex + 1;
            //Object selectedItem = selectSubCombo.SelectedItem;

            //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //                "Index: " + selectedIndex);

            if (!Authenticate())
            {
                MessageBox.Show("Don't keep any textbox blank!");
                return;
            }
           
            string query = "INSERT INTO Questions(Subject_id, Content, Answer1, Answer2, Answer3, Answer4, CorrectAnswer)" +
                "VALUES (@Subject_id, @Content, @Answer1, @Answer2, @Answer3, @Answer4, @CorrectAnswer)";
               
            con.Open();
           
            scmd = new SqlCommand(query, con);

            //add parameters

            scmd.Parameters.Add("@Subject_id", SqlDbType.Int);
            scmd.Parameters["@Subject_id"].Value = comboBox1.SelectedIndex+1;

            scmd.Parameters.Add("@Content", SqlDbType.NVarChar);
            scmd.Parameters["@Content"].Value = questionContent.Text;

            scmd.Parameters.Add("@Answer1", SqlDbType.NVarChar);
            scmd.Parameters["@Answer1"].Value = answerA.Text;

            scmd.Parameters.Add("@Answer2", SqlDbType.NVarChar);
            scmd.Parameters["@Answer2"].Value = answerB.Text;

            scmd.Parameters.Add("@Answer3", SqlDbType.NVarChar);
            scmd.Parameters["@Answer3"].Value = answerC.Text;

            scmd.Parameters.Add("@Answer4", SqlDbType.NVarChar);
            scmd.Parameters["@Answer4"].Value = answerD.Text;

            scmd.Parameters.Add("@CorrectAnswer", SqlDbType.NVarChar);
            scmd.Parameters["@CorrectAnswer"].Value = CorrectAnswer.Text;

            scmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Added");


        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(questionContent.Text) ||
                string.IsNullOrWhiteSpace(answerA.Text) ||
                string.IsNullOrWhiteSpace(answerB.Text) ||
                string.IsNullOrWhiteSpace(answerC.Text) ||
                string.IsNullOrWhiteSpace(answerD.Text) ||
                string.IsNullOrWhiteSpace(CorrectAnswer.Text)
                )

                return false;
            else return true;

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
        private void UC_AddNewQuestion_Load(object sender, EventArgs e)
        {
            ComboLoad();

        }
    }
}
