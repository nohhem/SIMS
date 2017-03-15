namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.tab_CourseTaking = new System.Windows.Forms.TabPage();
            this.tab_Courses = new System.Windows.Forms.TabPage();
            this.Academic_tab = new System.Windows.Forms.TabPage();
            this.info_tab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_RegisterDate = new System.Windows.Forms.Label();
            this.lbl_rgYear = new System.Windows.Forms.Label();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_passNO = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Nationalty = new System.Windows.Forms.Label();
            this.lbl_nationalId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_chagneConfirmation = new System.Windows.Forms.Button();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Courses.SuspendLayout();
            this.info_tab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_CourseTaking
            // 
            this.tab_CourseTaking.Location = new System.Drawing.Point(4, 22);
            this.tab_CourseTaking.Name = "tab_CourseTaking";
            this.tab_CourseTaking.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CourseTaking.Size = new System.Drawing.Size(717, 368);
            this.tab_CourseTaking.TabIndex = 3;
            this.tab_CourseTaking.Text = "Course Taking";
            this.tab_CourseTaking.UseVisualStyleBackColor = true;
            // 
            // tab_Courses
            // 
            this.tab_Courses.Controls.Add(this.dataGridView1);
            this.tab_Courses.Location = new System.Drawing.Point(4, 22);
            this.tab_Courses.Name = "tab_Courses";
            this.tab_Courses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Courses.Size = new System.Drawing.Size(717, 368);
            this.tab_Courses.TabIndex = 2;
            this.tab_Courses.Text = "Courses";
            this.tab_Courses.UseVisualStyleBackColor = true;
            // 
            // Academic_tab
            // 
            this.Academic_tab.Location = new System.Drawing.Point(4, 22);
            this.Academic_tab.Name = "Academic_tab";
            this.Academic_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Academic_tab.Size = new System.Drawing.Size(717, 368);
            this.Academic_tab.TabIndex = 1;
            this.Academic_tab.Text = "Academic";
            this.Academic_tab.UseVisualStyleBackColor = true;
            // 
            // info_tab
            // 
            this.info_tab.Controls.Add(this.groupBox4);
            this.info_tab.Controls.Add(this.groupBox3);
            this.info_tab.Controls.Add(this.groupBox2);
            this.info_tab.Controls.Add(this.groupBox1);
            this.info_tab.Controls.Add(this.textBox8);
            this.info_tab.Location = new System.Drawing.Point(4, 22);
            this.info_tab.Name = "info_tab";
            this.info_tab.Padding = new System.Windows.Forms.Padding(3);
            this.info_tab.Size = new System.Drawing.Size(717, 368);
            this.info_tab.TabIndex = 0;
            this.info_tab.Text = "Info";
            this.info_tab.UseVisualStyleBackColor = true;
            this.info_tab.Click += new System.EventHandler(this.Academic_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbl_Department);
            this.groupBox3.Controls.Add(this.lbl_RegisterDate);
            this.groupBox3.Controls.Add(this.lbl_rgYear);
            this.groupBox3.Controls.Add(this.lbl_StuID);
            this.groupBox3.Controls.Add(this.lbl_Lname);
            this.groupBox3.Controls.Add(this.lbl_name);
            this.groupBox3.Location = new System.Drawing.Point(10, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 199);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Registeration Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Registeration year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Student ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Name";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Location = new System.Drawing.Point(123, 162);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(62, 13);
            this.lbl_Department.TabIndex = 34;
            this.lbl_Department.Text = "Department";
            // 
            // lbl_RegisterDate
            // 
            this.lbl_RegisterDate.AutoSize = true;
            this.lbl_RegisterDate.Location = new System.Drawing.Point(123, 133);
            this.lbl_RegisterDate.Name = "lbl_RegisterDate";
            this.lbl_RegisterDate.Size = new System.Drawing.Size(95, 13);
            this.lbl_RegisterDate.TabIndex = 33;
            this.lbl_RegisterDate.Text = "Registeration Date";
            // 
            // lbl_rgYear
            // 
            this.lbl_rgYear.AutoSize = true;
            this.lbl_rgYear.Location = new System.Drawing.Point(123, 108);
            this.lbl_rgYear.Name = "lbl_rgYear";
            this.lbl_rgYear.Size = new System.Drawing.Size(92, 13);
            this.lbl_rgYear.TabIndex = 32;
            this.lbl_rgYear.Text = "Registeration year";
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Location = new System.Drawing.Point(123, 82);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(58, 13);
            this.lbl_StuID.TabIndex = 31;
            this.lbl_StuID.Text = "Student ID";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Location = new System.Drawing.Point(123, 56);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(58, 13);
            this.lbl_Lname.TabIndex = 30;
            this.lbl_Lname.Text = "Last Name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(123, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 29;
            this.lbl_name.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.lbl_passNO);
            this.groupBox2.Controls.Add(this.lbl_birthday);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_Nationalty);
            this.groupBox2.Controls.Add(this.lbl_nationalId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 149);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(129, 16);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbl_passNO
            // 
            this.lbl_passNO.AutoSize = true;
            this.lbl_passNO.Location = new System.Drawing.Point(129, 119);
            this.lbl_passNO.Name = "lbl_passNO";
            this.lbl_passNO.Size = new System.Drawing.Size(82, 13);
            this.lbl_passNO.TabIndex = 32;
            this.lbl_passNO.Text = "Passort Number";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(129, 42);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(45, 13);
            this.lbl_birthday.TabIndex = 4;
            this.lbl_birthday.Text = "Birthday";
            this.lbl_birthday.Click += new System.EventHandler(this.lbl_birthday_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Passort Number";
            // 
            // lbl_Nationalty
            // 
            this.lbl_Nationalty.AutoSize = true;
            this.lbl_Nationalty.Location = new System.Drawing.Point(129, 70);
            this.lbl_Nationalty.Name = "lbl_Nationalty";
            this.lbl_Nationalty.Size = new System.Drawing.Size(54, 13);
            this.lbl_Nationalty.TabIndex = 5;
            this.lbl_Nationalty.Text = "Nationalty";
            this.lbl_Nationalty.Click += new System.EventHandler(this.lbl_Nationalty_Click);
            // 
            // lbl_nationalId
            // 
            this.lbl_nationalId.AutoSize = true;
            this.lbl_nationalId.Location = new System.Drawing.Point(129, 96);
            this.lbl_nationalId.Name = "lbl_nationalId";
            this.lbl_nationalId.Size = new System.Drawing.Size(60, 13);
            this.lbl_nationalId.TabIndex = 6;
            this.lbl_nationalId.Text = "National ID";
            this.lbl_nationalId.Click += new System.EventHandler(this.lbl_nationalId_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nationalty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "National ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Location = new System.Drawing.Point(363, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 130);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(6, 16);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 29;
            this.lbl_address.Text = "Address";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(-60, 366);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.info_tab);
            this.tabControl1.Controls.Add(this.Academic_tab);
            this.tabControl1.Controls.Add(this.tab_Courses);
            this.tabControl1.Controls.Add(this.tab_CourseTaking);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 394);
            this.tabControl1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCode,
            this.CourseName,
            this.Credit,
            this.Type,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(9, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_chagneConfirmation);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(388, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 151);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "new Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Verify Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_chagneConfirmation
            // 
            this.btn_chagneConfirmation.Location = new System.Drawing.Point(194, 119);
            this.btn_chagneConfirmation.Name = "btn_chagneConfirmation";
            this.btn_chagneConfirmation.Size = new System.Drawing.Size(75, 23);
            this.btn_chagneConfirmation.TabIndex = 6;
            this.btn_chagneConfirmation.Text = "Change";
            this.btn_chagneConfirmation.UseVisualStyleBackColor = true;
            // 
            // CourseCode
            // 
            this.CourseCode.Frozen = true;
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.Name = "CourseCode";
            // 
            // CourseName
            // 
            this.CourseName.Frozen = true;
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            // 
            // Credit
            // 
            this.Credit.Frozen = true;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_Courses.ResumeLayout(false);
            this.info_tab.ResumeLayout(false);
            this.info_tab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_CourseTaking;
        private System.Windows.Forms.TabPage tab_Courses;
        private System.Windows.Forms.TabPage Academic_tab;
        private System.Windows.Forms.TabPage info_tab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nationalId;
        private System.Windows.Forms.Label lbl_Nationalty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_RegisterDate;
        private System.Windows.Forms.Label lbl_rgYear;
        private System.Windows.Forms.Label lbl_StuID;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_passNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_chagneConfirmation;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

