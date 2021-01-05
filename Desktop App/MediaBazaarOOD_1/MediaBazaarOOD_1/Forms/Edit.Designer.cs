namespace MediaBazaarOOD_1.Forms
{
    partial class Edit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgEdit = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIdEdit = new System.Windows.Forms.TextBox();
            this.tbFnEdit = new System.Windows.Forms.TextBox();
            this.tbLnEdit = new System.Windows.Forms.TextBox();
            this.tbAgeEdit = new System.Windows.Forms.TextBox();
            this.tbAddressEdit = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSalaryEdit = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbDnameEdit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.cmbDnameEdit);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dtpHireDate);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.tbSalaryEdit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.tbAddressEdit);
            this.groupBox1.Controls.Add(this.tbAgeEdit);
            this.groupBox1.Controls.Add(this.tbLnEdit);
            this.groupBox1.Controls.Add(this.tbFnEdit);
            this.groupBox1.Controls.Add(this.tbIdEdit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtgEdit);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtgEdit
            // 
            this.dtgEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEdit.Location = new System.Drawing.Point(332, 21);
            this.dtgEdit.Name = "dtgEdit";
            this.dtgEdit.RowHeadersWidth = 51;
            this.dtgEdit.RowTemplate.Height = 24;
            this.dtgEdit.Size = new System.Drawing.Size(483, 431);
            this.dtgEdit.TabIndex = 0;
            this.dtgEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEdit_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(551, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go back Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Department Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Address";
            // 
            // tbIdEdit
            // 
            this.tbIdEdit.Location = new System.Drawing.Point(130, 52);
            this.tbIdEdit.Name = "tbIdEdit";
            this.tbIdEdit.Size = new System.Drawing.Size(121, 22);
            this.tbIdEdit.TabIndex = 12;
            // 
            // tbFnEdit
            // 
            this.tbFnEdit.Location = new System.Drawing.Point(130, 82);
            this.tbFnEdit.Name = "tbFnEdit";
            this.tbFnEdit.Size = new System.Drawing.Size(121, 22);
            this.tbFnEdit.TabIndex = 13;
            // 
            // tbLnEdit
            // 
            this.tbLnEdit.Location = new System.Drawing.Point(130, 113);
            this.tbLnEdit.Name = "tbLnEdit";
            this.tbLnEdit.Size = new System.Drawing.Size(121, 22);
            this.tbLnEdit.TabIndex = 14;
            // 
            // tbAgeEdit
            // 
            this.tbAgeEdit.Location = new System.Drawing.Point(130, 141);
            this.tbAgeEdit.Name = "tbAgeEdit";
            this.tbAgeEdit.Size = new System.Drawing.Size(121, 22);
            this.tbAgeEdit.TabIndex = 15;
            // 
            // tbAddressEdit
            // 
            this.tbAddressEdit.Location = new System.Drawing.Point(130, 430);
            this.tbAddressEdit.Name = "tbAddressEdit";
            this.tbAddressEdit.Size = new System.Drawing.Size(121, 22);
            this.tbAddressEdit.TabIndex = 16;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(130, 169);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 19;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(130, 469);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 24);
            this.cmbRole.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Role";
            // 
            // tbSalaryEdit
            // 
            this.tbSalaryEdit.Location = new System.Drawing.Point(130, 389);
            this.tbSalaryEdit.Name = "tbSalaryEdit";
            this.tbSalaryEdit.Size = new System.Drawing.Size(121, 22);
            this.tbSalaryEdit.TabIndex = 23;
            this.tbSalaryEdit.TextChanged += new System.EventHandler(this.tbSalary_TextChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(116, 343);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 24;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(116, 296);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 22);
            this.dtpHireDate.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(351, 462);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 45);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbDnameEdit
            // 
            this.cmbDnameEdit.FormattingEnabled = true;
            this.cmbDnameEdit.Location = new System.Drawing.Point(130, 240);
            this.cmbDnameEdit.Name = "cmbDnameEdit";
            this.cmbDnameEdit.Size = new System.Drawing.Size(121, 24);
            this.cmbDnameEdit.TabIndex = 27;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1048, 599);
            this.Controls.Add(this.groupBox1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbSalaryEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox tbAddressEdit;
        private System.Windows.Forms.TextBox tbAgeEdit;
        private System.Windows.Forms.TextBox tbLnEdit;
        private System.Windows.Forms.TextBox tbFnEdit;
        private System.Windows.Forms.TextBox tbIdEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbDnameEdit;
    }
}