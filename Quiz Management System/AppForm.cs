using Quiz_Management_System.Teacher_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Management_System
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AppForm_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            newSubject1.Visible = false;
            udelete1.Visible = false;
            uUpdate1.Visible = false;
            uStuReg1.Visible = false;
            ustuResults1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //contentPanel.Hide();
            uC_AddNewQuestion1.Visible = true;
            newSubject1.Visible = false;
            udelete1.Visible = false;
            uUpdate1.Visible = false;
            uStuReg1.Visible = false;
            ustuResults1.Visible = false;



        }

        private void button7_Click(object sender, EventArgs e)
        {
            newSubject1.Visible = true;
            uC_AddNewQuestion1.Visible = false;
            udelete1.Visible = false;
            uUpdate1.Visible = false;
            uStuReg1.Visible = false;
            ustuResults1.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            uUpdate1.Visible = true;
            newSubject1.Visible = false;
            uC_AddNewQuestion1.Visible = false;
            udelete1.Visible = false;
            uStuReg1.Visible = false;
            ustuResults1.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            udelete1.Visible = true;
            uC_AddNewQuestion1.Visible = false;
            newSubject1.Visible = false;
            uUpdate1.Visible = false;
            uStuReg1.Visible = false;
            ustuResults1.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            uStuReg1.Visible = true;
            udelete1.Visible = false;
            uC_AddNewQuestion1.Visible = false;
            newSubject1.Visible = false;
            uUpdate1.Visible = false;
            ustuResults1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ustuResults1.Visible = true;
            uStuReg1.Visible = false;
            udelete1.Visible = false;
            uC_AddNewQuestion1.Visible = false;
            newSubject1.Visible = false;
            uUpdate1.Visible = false;
        }
    }
}
