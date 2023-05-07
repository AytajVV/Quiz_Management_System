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
    public partial class RegisterForm : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Don't keep any textbox blank!");
                return;
            }
            string query = "INSERT INTO Teachers VALUES (@Name, @Surname, @Number, @Email, @Password)";
            con.Open();
            scmd = new SqlCommand(query, con);

            //add parameters

            scmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            scmd.Parameters["@Name"].Value = NameTxt.Text;

            scmd.Parameters.Add("@Surname", SqlDbType.NVarChar);
            scmd.Parameters["@Surname"].Value = SurnameTxt.Text;

            scmd.Parameters.Add("@Number", SqlDbType.NVarChar);
            scmd.Parameters["@Number"].Value = NumTxt.Text;

            scmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            scmd.Parameters["@Email"].Value = EmailTxt.Text;

            scmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            scmd.Parameters["@Password"].Value = PassTxt.Text;

            scmd.ExecuteNonQuery();
            con.Close();
        }

        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(NameTxt.Text) ||
                string.IsNullOrWhiteSpace(SurnameTxt.Text) ||
                string.IsNullOrWhiteSpace(NumTxt.Text) ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                string.IsNullOrWhiteSpace(PassTxt.Text)
                )

                return false;
            else return true;
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
