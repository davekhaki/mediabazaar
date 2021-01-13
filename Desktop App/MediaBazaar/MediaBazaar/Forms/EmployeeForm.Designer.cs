namespace MediaBazaarOO.Forms
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scheduleMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.scheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDone = new System.Windows.Forms.Button();
            this.requestDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updatePreferenceBtn = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stockDataGrid = new System.Windows.Forms.DataGridView();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateStockBtn = new System.Windows.Forms.Button();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.scheduleMonthCalender);
            this.tabPage1.Controls.Add(this.scheduleDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule";
            // 
            // scheduleMonthCalender
            // 
            this.scheduleMonthCalender.Location = new System.Drawing.Point(224, 143);
            this.scheduleMonthCalender.Name = "scheduleMonthCalender";
            this.scheduleMonthCalender.TabIndex = 2;
            this.scheduleMonthCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.scheduleMonthCalender_DateChanged);
            // 
            // scheduleDataGrid
            // 
            this.scheduleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGrid.Location = new System.Drawing.Point(583, 143);
            this.scheduleDataGrid.Name = "scheduleDataGrid";
            this.scheduleDataGrid.RowHeadersVisible = false;
            this.scheduleDataGrid.RowHeadersWidth = 51;
            this.scheduleDataGrid.RowTemplate.Height = 24;
            this.scheduleDataGrid.Size = new System.Drawing.Size(262, 207);
            this.scheduleDataGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.btnDone);
            this.tabPage2.Controls.Add(this.requestDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1171, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Requests";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDone.Location = new System.Drawing.Point(776, 103);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(319, 53);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Mark Complete";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // requestDataGrid
            // 
            this.requestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGrid.Location = new System.Drawing.Point(34, 26);
            this.requestDataGrid.Name = "requestDataGrid";
            this.requestDataGrid.RowHeadersWidth = 51;
            this.requestDataGrid.RowTemplate.Height = 24;
            this.requestDataGrid.Size = new System.Drawing.Size(680, 443);
            this.requestDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1171, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updatePreferenceBtn);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(597, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 354);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule Preference";
            // 
            // updatePreferenceBtn
            // 
            this.updatePreferenceBtn.Location = new System.Drawing.Point(95, 212);
            this.updatePreferenceBtn.Name = "updatePreferenceBtn";
            this.updatePreferenceBtn.Size = new System.Drawing.Size(198, 50);
            this.updatePreferenceBtn.TabIndex = 4;
            this.updatePreferenceBtn.Text = "Update my preference";
            this.updatePreferenceBtn.UseVisualStyleBackColor = true;
            this.updatePreferenceBtn.Click += new System.EventHandler(this.updatePreferenceBtn_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(113, 137);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Evenings";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(113, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Afternoons";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(113, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mornings";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Weekends";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbNewPassword);
            this.groupBox1.Controls.Add(this.tbOldPassword);
            this.groupBox1.Controls.Add(this.changePasswordBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(179, 147);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(263, 22);
            this.tbNewPassword.TabIndex = 5;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(179, 81);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(263, 22);
            this.tbOldPassword.TabIndex = 4;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Cyan;
            this.changePasswordBtn.Location = new System.Drawing.Point(164, 244);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(169, 43);
            this.changePasswordBtn.TabIndex = 3;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Teal;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1171, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stockDataGrid);
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.tbProductId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateStockBtn);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 443);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Update";
            // 
            // stockDataGrid
            // 
            this.stockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.stockDataGrid.Location = new System.Drawing.Point(25, 43);
            this.stockDataGrid.Name = "stockDataGrid";
            this.stockDataGrid.RowHeadersWidth = 51;
            this.stockDataGrid.RowTemplate.Height = 24;
            this.stockDataGrid.Size = new System.Drawing.Size(653, 380);
            this.stockDataGrid.TabIndex = 5;
            this.stockDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stockDataGrid_CellMouseClick);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(794, 266);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(195, 22);
            this.tbQuantity.TabIndex = 4;
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(794, 84);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(195, 22);
            this.tbProductId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ProductID";
            // 
            // updateStockBtn
            // 
            this.updateStockBtn.BackColor = System.Drawing.Color.Teal;
            this.updateStockBtn.ForeColor = System.Drawing.Color.White;
            this.updateStockBtn.Location = new System.Drawing.Point(810, 324);
            this.updateStockBtn.Name = "updateStockBtn";
            this.updateStockBtn.Size = new System.Drawing.Size(162, 46);
            this.updateStockBtn.TabIndex = 0;
            this.updateStockBtn.Text = "Update";
            this.updateStockBtn.UseVisualStyleBackColor = false;
            this.updateStockBtn.Click += new System.EventHandler(this.updateStockBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(1019, 5);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(165, 43);
            this.signOutBtn.TabIndex = 2;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 553);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar scheduleMonthCalender;
        private System.Windows.Forms.DataGridView scheduleDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView requestDataGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updatePreferenceBtn;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView stockDataGrid;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateStockBtn;
        private System.Windows.Forms.Button signOutBtn;
    }
}