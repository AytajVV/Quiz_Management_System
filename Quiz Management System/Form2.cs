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
    public partial class Form2 : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M42063Q;Initial Catalog=Quiz_Management_System;Integrated Security=True");
        static SqlCommand scmd; 
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isEmailok = false, isPassok = false;
            if (!Authenticate())
            {
                MessageBox.Show("Don't keep any textbox blank!");
                return;
            }

            string query = "SELECT * FROM Teachers WHERE Email=@Email";
            con.Open();
            scmd = new SqlCommand(query, con);

            //add parameters

            scmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            scmd.Parameters["@Email"].Value = EmailLog.Text;


            SqlDataReader sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                isEmailok = true;
            }
            con.Close();

            con.Open();
            query = "SELECT * FROM Teachers WHERE Email=@Email AND Password=@Password";
            scmd = new SqlCommand(query, con);

            //add parameters

            scmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            scmd.Parameters["@Email"].Value = EmailLog.Text;

            scmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            scmd.Parameters["@Password"].Value = PassLog.Text;


            sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                isPassok = true;
            }

            if (isEmailok==false)
            {
                MessageBox.Show("User does not exist!");
            }
            else if (isEmailok == true && isPassok==false)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                Hide();
                AppForm app = new AppForm();
                app.ShowDialog();
                Close();
            }
            con.Close();
        }


        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(EmailLog.Text) ||
                string.IsNullOrWhiteSpace(PassLog.Text) 
                )

                return false;
            else return true;

        }
    }
}
