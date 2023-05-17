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
            this.label4 = new System.Windows.Forms.Label();
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
            this.excelfileName = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Subject and lecture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add subject";
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
            this.addSubBtn.Text = "Add";
            this.addSubBtn.UseVisualStyleBackColor = true;
            this.addSubBtn.Click += new System.EventHandler(this.addSubBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add lecture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add questions";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(132, 230);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(265, 23);
            this.filePath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(14, 307);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowTemplate.Height = 25;
            this.dgvDocuments.Size = new System.Drawing.Size(490, 65);
            this.dgvDocuments.TabIndex = 10;
            // 
            // subLec
            // 
            this.subLec.Location = new System.Drawing.Point(132, 267);
            this.subLec.Name = "subLec";
            this.subLec.Size = new System.Drawing.Size(139, 23);
            this.subLec.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subject id";
            // 
            // dgvSub
            // 
            this.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub.Location = new System.Drawing.Point(14, 115);
            this.dgvSub.Name = "dgvSub";
            this.dgvSub.RowTemplate.Height = 25;
            this.dgvSub.Size = new System.Drawing.Size(247, 65);
            this.dgvSub.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(410, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // excelfileName
            // 
            this.excelfileName.Location = new System.Drawing.Point(139, 417);
            this.excelfileName.Name = "excelfileName";
            this.excelfileName.Size = new System.Drawing.Size(265, 23);
            this.excelfileName.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Browse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Subject id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 23);
            this.textBox2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 503);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(490, 75);
            this.dataGridView1.TabIndex = 21;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(523, 417);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 24;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
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
            this.Controls.Add(this.import);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.excelfileName);
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
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox addnewsubtxt;
        private Button addSubBtn;
        private Label label3;
        private Label label4;
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
        private TextBox excelfileName;
        private Button button6;
        private Label label6;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button import;
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
