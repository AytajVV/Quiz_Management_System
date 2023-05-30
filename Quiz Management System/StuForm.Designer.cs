namespace Quiz_Management_System
{
    partial class StuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mühazirələrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uLecture1 = new Quiz_Management_System.uLecture();
            this.uQuiz1 = new Quiz_Management_System.uQuiz();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mühazirələrToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mühazirələrToolStripMenuItem
            // 
            this.mühazirələrToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.mühazirələrToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mühazirələrToolStripMenuItem.Name = "mühazirələrToolStripMenuItem";
            this.mühazirələrToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.mühazirələrToolStripMenuItem.Text = "Mühazirələr";
            this.mühazirələrToolStripMenuItem.Click += new System.EventHandler(this.mühazirələrToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(267, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, student!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Management_System.Properties.Resources.istockphoto_1183575653_612x612_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(104, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uLecture1
            // 
            this.uLecture1.BackColor = System.Drawing.Color.White;
            this.uLecture1.Location = new System.Drawing.Point(0, 33);
            this.uLecture1.Name = "uLecture1";
            this.uLecture1.Size = new System.Drawing.Size(800, 412);
            this.uLecture1.TabIndex = 3;
            this.uLecture1.Visible = false;
            // 
            // uQuiz1
            // 
            this.uQuiz1.BackColor = System.Drawing.Color.White;
            this.uQuiz1.Location = new System.Drawing.Point(0, 33);
            this.uQuiz1.Name = "uQuiz1";
            this.uQuiz1.Size = new System.Drawing.Size(800, 417);
           
            this.uQuiz1.TabIndex = 4;
            this.uQuiz1.Visible = false;
            this.uQuiz1.Load += new System.EventHandler(this.uQuiz1_Load);
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.uQuiz1);
            this.Controls.Add(this.uLecture1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuForm";
            this.Load += new System.EventHandler(this.StuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mühazirələrToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private uLecture uLecture1;
        private uQuiz uQuiz1;
    }
}