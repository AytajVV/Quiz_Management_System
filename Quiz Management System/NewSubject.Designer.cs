namespace Quiz_Management_System
{
    partial class NewSubject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addnewsubtxt = new System.Windows.Forms.TextBox();
            this.addSubBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.subLec = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSub = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni fənn və mühazirə";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni fənn";
            // 
            // addnewsubtxt
            // 
            this.addnewsubtxt.Location = new System.Drawing.Point(132, 74);
            this.addnewsubtxt.Name = "addnewsubtxt";
            this.addnewsubtxt.Size = new System.Drawing.Size(139, 23);
            this.addnewsubtxt.TabIndex = 3;
            // 
            // addSubBtn
            // 
            this.addSubBtn.Location = new System.Drawing.Point(305, 74);
            this.addSubBtn.Name = "addSubBtn";
            this.addSubBtn.Size = new System.Drawing.Size(75, 23);
            this.addSubBtn.TabIndex = 4;
            this.addSubBtn.Text = "Daxil et";
            this.addSubBtn.UseVisualStyleBackColor = true;
            this.addSubBtn.Click += new System.EventHandler(this.addSubBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni mühazirə";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(132, 328);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(265, 23);
            this.filePath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Daxil et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(12, 447);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowTemplate.Height = 25;
            this.dgvDocuments.Size = new System.Drawing.Size(490, 65);
            this.dgvDocuments.TabIndex = 10;
            this.dgvDocuments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellContentClick);
            // 
            // subLec
            // 
            this.subLec.Location = new System.Drawing.Point(132, 386);
            this.subLec.Name = "subLec";
            this.subLec.Size = new System.Drawing.Size(139, 23);
            this.subLec.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Aç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fənn İD";
            // 
            // dgvSub
            // 
            this.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub.Location = new System.Drawing.Point(14, 115);
            this.dgvSub.Name = "dgvSub";
            this.dgvSub.RowTemplate.Height = 25;
            this.dgvSub.Size = new System.Drawing.Size(257, 65);
            this.dgvSub.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Yenilə";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(305, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Yenilə";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // NewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.subLec);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addSubBtn);
            this.Controls.Add(this.addnewsubtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewSubject";
            this.Size = new System.Drawing.Size(654, 635);
            this.Load += new System.EventHandler(this.NewSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox addnewsubtxt;
        private Button addSubBtn;
        private Label label3;
        private TextBox filePath;
        private Button button1;
        private Button button2;
        private DataGridView dgvDocuments;
        private TextBox subLec;
        private Button button3;
        private Label label5;
        private DataGridView dgvSub;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answer1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answer2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answer3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answer4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private OpenFileDialog openFD;
    }
}
