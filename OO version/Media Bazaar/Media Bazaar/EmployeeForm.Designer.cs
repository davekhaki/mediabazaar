namespace Media_Bazaar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.newPasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signOutButton = new System.Windows.Forms.Button();
            this.scheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.changeUsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.currentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
            this.changeUsernameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2025, 939);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scheduleDataGrid);
            this.tabPage1.Controls.Add(this.scheduleCalendar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2017, 910);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scheduleCalendar
            // 
            this.scheduleCalendar.Location = new System.Drawing.Point(558, 336);
            this.scheduleCalendar.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.scheduleCalendar.MaxSelectionCount = 1;
            this.scheduleCalendar.MinDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.scheduleCalendar.Name = "scheduleCalendar";
            this.scheduleCalendar.TabIndex = 0;
            this.scheduleCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.scheduleCalendar_DateChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.Silver;
            this.settingsTab.Controls.Add(this.changeUsernameGroupBox);
            this.settingsTab.Controls.Add(this.groupBox1);
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(2017, 910);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangePasswordBtn);
            this.groupBox1.Controls.Add(this.newPasswordConfirmTextBox);
            this.groupBox1.Controls.Add(this.newPasswordTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oldPasswordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(518, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(79, 253);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(217, 48);
            this.ChangePasswordBtn.TabIndex = 1;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // newPasswordConfirmTextBox
            // 
            this.newPasswordConfirmTextBox.Location = new System.Drawing.Point(99, 209);
            this.newPasswordConfirmTextBox.Name = "newPasswordConfirmTextBox";
            this.newPasswordConfirmTextBox.Size = new System.Drawing.Size(169, 22);
            this.newPasswordConfirmTextBox.TabIndex = 5;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(99, 138);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(169, 22);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password confirm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current password";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(99, 66);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(169, 22);
            this.oldPasswordTextBox.TabIndex = 1;
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.Red;
            this.signOutButton.Location = new System.Drawing.Point(1798, 12);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(232, 43);
            this.signOutButton.TabIndex = 1;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // scheduleDataGrid
            // 
            this.scheduleDataGrid.AllowUserToAddRows = false;
            this.scheduleDataGrid.AllowUserToDeleteRows = false;
            this.scheduleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.scheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGrid.Location = new System.Drawing.Point(1012, 336);
            this.scheduleDataGrid.Name = "scheduleDataGrid";
            this.scheduleDataGrid.RowHeadersVisible = false;
            this.scheduleDataGrid.RowHeadersWidth = 51;
            this.scheduleDataGrid.RowTemplate.Height = 24;
            this.scheduleDataGrid.Size = new System.Drawing.Size(273, 207);
            this.scheduleDataGrid.TabIndex = 1;
            // 
            // changeUsernameGroupBox
            // 
            this.changeUsernameGroupBox.Controls.Add(this.newUsernameTextBox);
            this.changeUsernameGroupBox.Controls.Add(this.currentUsernameTextBox);
            this.changeUsernameGroupBox.Controls.Add(this.changeUsernameButton);
            this.changeUsernameGroupBox.Controls.Add(this.label5);
            this.changeUsernameGroupBox.Controls.Add(this.label4);
            this.changeUsernameGroupBox.Location = new System.Drawing.Point(57, 31);
            this.changeUsernameGroupBox.Name = "changeUsernameGroupBox";
            this.changeUsernameGroupBox.Size = new System.Drawing.Size(370, 319);
            this.changeUsernameGroupBox.TabIndex = 1;
            this.changeUsernameGroupBox.TabStop = false;
            this.changeUsernameGroupBox.Text = "Change Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "New username";
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Location = new System.Drawing.Point(57, 253);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(228, 45);
            this.changeUsernameButton.TabIndex = 2;
            this.changeUsernameButton.Text = "Submit";
            this.changeUsernameButton.UseVisualStyleBackColor = true;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // currentUsernameTextBox
            // 
            this.currentUsernameTextBox.Location = new System.Drawing.Point(88, 85);
            this.currentUsernameTextBox.Name = "currentUsernameTextBox";
            this.currentUsernameTextBox.Size = new System.Drawing.Size(169, 22);
            this.currentUsernameTextBox.TabIndex = 2;
            // 
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Location = new System.Drawing.Point(88, 191);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(169, 22);
            this.newUsernameTextBox.TabIndex = 3;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 790);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
            this.changeUsernameGroupBox.ResumeLayout(false);
            this.changeUsernameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.TextBox newPasswordConfirmTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.MonthCalendar scheduleCalendar;
        private System.Windows.Forms.DataGridView scheduleDataGrid;
        private System.Windows.Forms.GroupBox changeUsernameGroupBox;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.TextBox currentUsernameTextBox;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}