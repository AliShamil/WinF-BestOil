namespace WinF_Step_Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_add_change = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BirthDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Surname);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.btn_add_change);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forum";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(134, 228);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(328, 23);
            this.BirthDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(134, 186);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(328, 23);
            this.txt_Phone.TabIndex = 9;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(134, 145);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(328, 23);
            this.txt_Email.TabIndex = 8;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(134, 104);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(328, 23);
            this.txt_Surname.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(134, 63);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(328, 23);
            this.txt_Name.TabIndex = 6;
            // 
            // btn_add_change
            // 
            this.btn_add_change.Location = new System.Drawing.Point(377, 326);
            this.btn_add_change.Name = "btn_add_change";
            this.btn_add_change.Size = new System.Drawing.Size(85, 23);
            this.btn_add_change.TabIndex = 5;
            this.btn_add_change.Text = "Add";
            this.btn_add_change.UseVisualStyleBackColor = true;
            this.btn_add_change.Click += new System.EventHandler(this.btn_add_change_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(585, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 349);
            this.listBox1.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(585, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(585, 369);
            this.txtFile.Name = "txtFile";
            this.txtFile.PlaceholderText = "File Name";
            this.txtFile.Size = new System.Drawing.Size(189, 23);
            this.txtFile.TabIndex = 3;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(689, 398);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(85, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Phone;
        private TextBox txt_Email;
        private TextBox txt_Surname;
        private TextBox txt_Name;
        private Button btn_add_change;
        private ListBox listBox1;
        private Button btn_save;
        private TextBox txtFile;
        private Button btn_load;
        private DateTimePicker BirthDate;
    }
}