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
    public partial class StuForm : Form
    {
       
        public StuForm()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void mühazirələrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uLecture1.Visible = true;
            uQuiz1.Visible = false;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uQuiz1.Visible = true;
            uLecture1.Visible = false;
            
        }

        private void StuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void uQuiz1_Load(object sender, EventArgs e)
        {

        }
    }
}
