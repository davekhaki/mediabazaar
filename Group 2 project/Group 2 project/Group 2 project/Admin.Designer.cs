namespace Group_2_project
{
    partial class Admin
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
            this.dShow = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbSal = new System.Windows.Forms.TextBox();
            this.tbHdate = new System.Windows.Forms.TextBox();
            this.tbDid = new System.Windows.Forms.TextBox();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSn = new System.Windows.Forms.TextBox();
            this.tbFn = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dShow
            // 
            this.dShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dShow.Location = new System.Drawing.Point(496, 12);
            this.dShow.Name = "dShow";
            this.dShow.RowHeadersWidth = 51;
            this.dShow.RowTemplate.Height = 24;
            this.dShow.Size = new System.Drawing.Size(292, 415);
            this.dShow.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnDeleteEmp);
            this.groupBox1.Controls.Add(this.btnUpdateEmp);
            this.groupBox1.Controls.Add(this.btnAddEmp);
            this.groupBox1.Controls.Add(this.tbRole);
            this.groupBox1.Controls.Add(this.tbAdd);
            this.groupBox1.Controls.Add(this.tbSal);
            this.groupBox1.Controls.Add(this.tbHdate);
            this.groupBox1.Controls.Add(this.tbDid);
            this.groupBox1.Controls.Add(this.tbGen);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.tbSn);
            this.groupBox1.Controls.Add(this.tbFn);
            this.groupBox1.Controls.Add(this.tbId);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Admin Page";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Yellow;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(299, 262);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 46);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Show Employees";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEmp.Location = new System.Drawing.Point(299, 183);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(126, 53);
            this.btnDeleteEmp.TabIndex = 22;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateEmp.Location = new System.Drawing.Point(299, 98);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(126, 48);
            this.btnUpdateEmp.TabIndex = 21;
            this.btnUpdateEmp.Text = "Update Employee Details";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.White;
            this.btnAddEmp.Location = new System.Drawing.Point(290, 42);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(126, 38);
            this.btnAddEmp.TabIndex = 20;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(142, 333);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(100, 22);
            this.tbRole.TabIndex = 19;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(142, 302);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 22);
            this.tbAdd.TabIndex = 18;
            // 
            // tbSal
            // 
            this.tbSal.Location = new System.Drawing.Point(142, 262);
            this.tbSal.Name = "tbSal";
            this.tbSal.Size = new System.Drawing.Size(100, 22);
            this.tbSal.TabIndex = 17;
            // 
            // tbHdate
            // 
            this.tbHdate.Location = new System.Drawing.Point(142, 219);
            this.tbHdate.Name = "tbHdate";
            this.tbHdate.Size = new System.Drawing.Size(100, 22);
            this.tbHdate.TabIndex = 16;
            // 
            // tbDid
            // 
            this.tbDid.Location = new System.Drawing.Point(142, 183);
            this.tbDid.Name = "tbDid";
            this.tbDid.Size = new System.Drawing.Size(100, 22);
            this.tbDid.TabIndex = 15;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(142, 154);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(100, 22);
            this.tbGen.TabIndex = 14;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(142, 126);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 13;
            // 
            // tbSn
            // 
            this.tbSn.Location = new System.Drawing.Point(142, 98);
            this.tbSn.Name = "tbSn";
            this.tbSn.Size = new System.Drawing.Size(100, 22);
            this.tbSn.TabIndex = 12;
            // 
            // tbFn
            // 
            this.tbFn.Location = new System.Drawing.Point(142, 70);
            this.tbFn.Name = "tbFn";
            this.tbFn.Size = new System.Drawing.Size(100, 22);
            this.tbFn.TabIndex = 11;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(142, 42);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hire Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "DepartId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SecondName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dShow);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbSal;
        private System.Windows.Forms.TextBox tbHdate;
        private System.Windows.Forms.TextBox tbDid;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSn;
        private System.Windows.Forms.TextBox tbFn;
        private System.Windows.Forms.TextBox tbId;
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
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button btnShow;
    }
}