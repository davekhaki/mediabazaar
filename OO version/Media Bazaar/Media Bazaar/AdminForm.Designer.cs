namespace Media_Bazaar
{
    sealed partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.enableAllButton = new System.Windows.Forms.Button();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.roleCheckBox = new System.Windows.Forms.CheckBox();
            this.addressCheckBox = new System.Windows.Forms.CheckBox();
            this.salaryCheckBox = new System.Windows.Forms.CheckBox();
            this.endDateCheckBox = new System.Windows.Forms.CheckBox();
            this.hireDateCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentCheckBox = new System.Windows.Forms.CheckBox();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            this.ageCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.firstNameCheckBox = new System.Windows.Forms.CheckBox();
            this.idCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteDepartmentsButton = new System.Windows.Forms.Button();
            this.updateDetailsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentIdTextBox = new System.Windows.Forms.TextBox();
            this.departmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.employeeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGrid.Location = new System.Drawing.Point(371, 151);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.RowHeadersWidth = 51;
            this.employeeDataGrid.RowTemplate.Height = 24;
            this.employeeDataGrid.Size = new System.Drawing.Size(1072, 699);
            this.employeeDataGrid.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.statisticsTab);
            this.TabControl1.Location = new System.Drawing.Point(12, 42);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(2352, 1182);
            this.TabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.filtersGroupBox);
            this.tabPage1.Controls.Add(this.employeeDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2344, 1153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(602, 85);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(647, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.button1);
            this.filtersGroupBox.Controls.Add(this.enableAllButton);
            this.filtersGroupBox.Controls.Add(this.emailCheckBox);
            this.filtersGroupBox.Controls.Add(this.roleCheckBox);
            this.filtersGroupBox.Controls.Add(this.addressCheckBox);
            this.filtersGroupBox.Controls.Add(this.salaryCheckBox);
            this.filtersGroupBox.Controls.Add(this.endDateCheckBox);
            this.filtersGroupBox.Controls.Add(this.hireDateCheckBox);
            this.filtersGroupBox.Controls.Add(this.departmentCheckBox);
            this.filtersGroupBox.Controls.Add(this.genderCheckBox);
            this.filtersGroupBox.Controls.Add(this.ageCheckBox);
            this.filtersGroupBox.Controls.Add(this.lastNameCheckBox);
            this.filtersGroupBox.Controls.Add(this.firstNameCheckBox);
            this.filtersGroupBox.Controls.Add(this.idCheckBox);
            this.filtersGroupBox.Location = new System.Drawing.Point(6, 29);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(344, 821);
            this.filtersGroupBox.TabIndex = 1;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Disable All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enableAllButton
            // 
            this.enableAllButton.Location = new System.Drawing.Point(31, 379);
            this.enableAllButton.Name = "enableAllButton";
            this.enableAllButton.Size = new System.Drawing.Size(188, 46);
            this.enableAllButton.TabIndex = 4;
            this.enableAllButton.Text = "Enable All";
            this.enableAllButton.UseVisualStyleBackColor = true;
            this.enableAllButton.Click += new System.EventHandler(this.enableAllButton_Click);
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Checked = true;
            this.emailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailCheckBox.Location = new System.Drawing.Point(31, 311);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(64, 21);
            this.emailCheckBox.TabIndex = 15;
            this.emailCheckBox.Text = "Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            this.emailCheckBox.CheckedChanged += new System.EventHandler(this.emailCheckBox_CheckedChanged);
            // 
            // roleCheckBox
            // 
            this.roleCheckBox.AutoSize = true;
            this.roleCheckBox.Location = new System.Drawing.Point(31, 338);
            this.roleCheckBox.Name = "roleCheckBox";
            this.roleCheckBox.Size = new System.Drawing.Size(59, 21);
            this.roleCheckBox.TabIndex = 14;
            this.roleCheckBox.Text = "Role";
            this.roleCheckBox.UseVisualStyleBackColor = true;
            this.roleCheckBox.CheckedChanged += new System.EventHandler(this.roleCheckBox_CheckedChanged);
            // 
            // addressCheckBox
            // 
            this.addressCheckBox.AutoSize = true;
            this.addressCheckBox.Location = new System.Drawing.Point(31, 284);
            this.addressCheckBox.Name = "addressCheckBox";
            this.addressCheckBox.Size = new System.Drawing.Size(82, 21);
            this.addressCheckBox.TabIndex = 13;
            this.addressCheckBox.Text = "Address";
            this.addressCheckBox.UseVisualStyleBackColor = true;
            this.addressCheckBox.CheckedChanged += new System.EventHandler(this.addressCheckBox_CheckedChanged);
            // 
            // salaryCheckBox
            // 
            this.salaryCheckBox.AutoSize = true;
            this.salaryCheckBox.Checked = true;
            this.salaryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.salaryCheckBox.Location = new System.Drawing.Point(31, 257);
            this.salaryCheckBox.Name = "salaryCheckBox";
            this.salaryCheckBox.Size = new System.Drawing.Size(70, 21);
            this.salaryCheckBox.TabIndex = 12;
            this.salaryCheckBox.Text = "Salary";
            this.salaryCheckBox.UseVisualStyleBackColor = true;
            this.salaryCheckBox.CheckedChanged += new System.EventHandler(this.salaryCheckBox_CheckedChanged);
            // 
            // endDateCheckBox
            // 
            this.endDateCheckBox.AutoSize = true;
            this.endDateCheckBox.Location = new System.Drawing.Point(31, 230);
            this.endDateCheckBox.Name = "endDateCheckBox";
            this.endDateCheckBox.Size = new System.Drawing.Size(158, 21);
            this.endDateCheckBox.TabIndex = 11;
            this.endDateCheckBox.Text = "Unemployment Date";
            this.endDateCheckBox.UseVisualStyleBackColor = true;
            this.endDateCheckBox.CheckedChanged += new System.EventHandler(this.endDateCheckBox_CheckedChanged);
            // 
            // hireDateCheckBox
            // 
            this.hireDateCheckBox.AutoSize = true;
            this.hireDateCheckBox.Checked = true;
            this.hireDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hireDateCheckBox.Location = new System.Drawing.Point(31, 203);
            this.hireDateCheckBox.Name = "hireDateCheckBox";
            this.hireDateCheckBox.Size = new System.Drawing.Size(141, 21);
            this.hireDateCheckBox.TabIndex = 10;
            this.hireDateCheckBox.Text = "Employment Date";
            this.hireDateCheckBox.UseVisualStyleBackColor = true;
            this.hireDateCheckBox.CheckedChanged += new System.EventHandler(this.hireDateCheckBox_CheckedChanged);
            // 
            // departmentCheckBox
            // 
            this.departmentCheckBox.AutoSize = true;
            this.departmentCheckBox.Checked = true;
            this.departmentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.departmentCheckBox.Location = new System.Drawing.Point(31, 176);
            this.departmentCheckBox.Name = "departmentCheckBox";
            this.departmentCheckBox.Size = new System.Drawing.Size(104, 21);
            this.departmentCheckBox.TabIndex = 9;
            this.departmentCheckBox.Text = "Department";
            this.departmentCheckBox.UseVisualStyleBackColor = true;
            this.departmentCheckBox.CheckedChanged += new System.EventHandler(this.departmentCheckBox_CheckedChanged);
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.AutoSize = true;
            this.genderCheckBox.Location = new System.Drawing.Point(31, 149);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(78, 21);
            this.genderCheckBox.TabIndex = 8;
            this.genderCheckBox.Text = "Gender";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            this.genderCheckBox.CheckedChanged += new System.EventHandler(this.genderCheckBox_CheckedChanged);
            // 
            // ageCheckBox
            // 
            this.ageCheckBox.AutoSize = true;
            this.ageCheckBox.Location = new System.Drawing.Point(31, 122);
            this.ageCheckBox.Name = "ageCheckBox";
            this.ageCheckBox.Size = new System.Drawing.Size(55, 21);
            this.ageCheckBox.TabIndex = 7;
            this.ageCheckBox.Text = "Age";
            this.ageCheckBox.UseVisualStyleBackColor = true;
            this.ageCheckBox.CheckedChanged += new System.EventHandler(this.ageCheckBox_CheckedChanged);
            // 
            // lastNameCheckBox
            // 
            this.lastNameCheckBox.AutoSize = true;
            this.lastNameCheckBox.Checked = true;
            this.lastNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lastNameCheckBox.Location = new System.Drawing.Point(31, 95);
            this.lastNameCheckBox.Name = "lastNameCheckBox";
            this.lastNameCheckBox.Size = new System.Drawing.Size(98, 21);
            this.lastNameCheckBox.TabIndex = 6;
            this.lastNameCheckBox.Text = "Last Name";
            this.lastNameCheckBox.UseVisualStyleBackColor = true;
            this.lastNameCheckBox.CheckedChanged += new System.EventHandler(this.lastNameCheckBox_CheckedChanged);
            // 
            // firstNameCheckBox
            // 
            this.firstNameCheckBox.AutoSize = true;
            this.firstNameCheckBox.Checked = true;
            this.firstNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstNameCheckBox.Location = new System.Drawing.Point(31, 68);
            this.firstNameCheckBox.Name = "firstNameCheckBox";
            this.firstNameCheckBox.Size = new System.Drawing.Size(98, 21);
            this.firstNameCheckBox.TabIndex = 5;
            this.firstNameCheckBox.Text = "First Name";
            this.firstNameCheckBox.UseVisualStyleBackColor = true;
            this.firstNameCheckBox.CheckedChanged += new System.EventHandler(this.firstNameCheckBox_CheckedChanged);
            // 
            // idCheckBox
            // 
            this.idCheckBox.AutoSize = true;
            this.idCheckBox.Checked = true;
            this.idCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idCheckBox.Location = new System.Drawing.Point(31, 41);
            this.idCheckBox.Name = "idCheckBox";
            this.idCheckBox.Size = new System.Drawing.Size(43, 21);
            this.idCheckBox.TabIndex = 4;
            this.idCheckBox.Text = "ID";
            this.idCheckBox.UseVisualStyleBackColor = true;
            this.idCheckBox.CheckedChanged += new System.EventHandler(this.idCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.departmentsDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2344, 1153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Department Overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteDepartmentsButton);
            this.groupBox2.Controls.Add(this.updateDetailsButton);
            this.groupBox2.Location = new System.Drawing.Point(100, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // deleteDepartmentsButton
            // 
            this.deleteDepartmentsButton.Location = new System.Drawing.Point(81, 127);
            this.deleteDepartmentsButton.Name = "deleteDepartmentsButton";
            this.deleteDepartmentsButton.Size = new System.Drawing.Size(167, 55);
            this.deleteDepartmentsButton.TabIndex = 4;
            this.deleteDepartmentsButton.Text = "Delete Department";
            this.deleteDepartmentsButton.UseVisualStyleBackColor = true;
            // 
            // updateDetailsButton
            // 
            this.updateDetailsButton.Location = new System.Drawing.Point(81, 39);
            this.updateDetailsButton.Name = "updateDetailsButton";
            this.updateDetailsButton.Size = new System.Drawing.Size(167, 55);
            this.updateDetailsButton.TabIndex = 3;
            this.updateDetailsButton.Text = "Update Details";
            this.updateDetailsButton.UseVisualStyleBackColor = true;
            this.updateDetailsButton.Click += new System.EventHandler(this.updateDetailsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.departmentNameTextBox);
            this.groupBox1.Controls.Add(this.departmentIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(100, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(81, 137);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(167, 22);
            this.departmentNameTextBox.TabIndex = 4;
            // 
            // departmentIdTextBox
            // 
            this.departmentIdTextBox.Location = new System.Drawing.Point(81, 65);
            this.departmentIdTextBox.Name = "departmentIdTextBox";
            this.departmentIdTextBox.ReadOnly = true;
            this.departmentIdTextBox.Size = new System.Drawing.Size(167, 22);
            this.departmentIdTextBox.TabIndex = 3;
            // 
            // departmentsDataGrid
            // 
            this.departmentsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.departmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGrid.Location = new System.Drawing.Point(737, 288);
            this.departmentsDataGrid.Name = "departmentsDataGrid";
            this.departmentsDataGrid.RowHeadersWidth = 51;
            this.departmentsDataGrid.RowTemplate.Height = 24;
            this.departmentsDataGrid.Size = new System.Drawing.Size(291, 170);
            this.departmentsDataGrid.TabIndex = 0;
            this.departmentsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDataGrid_CellClick);
            // 
            // statisticsTab
            // 
            this.statisticsTab.Location = new System.Drawing.Point(4, 25);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Size = new System.Drawing.Size(2344, 1153);
            this.statisticsTab.TabIndex = 2;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1269, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 432);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.TabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGrid;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.CheckBox ageCheckBox;
        private System.Windows.Forms.CheckBox lastNameCheckBox;
        private System.Windows.Forms.CheckBox firstNameCheckBox;
        private System.Windows.Forms.CheckBox idCheckBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
        private System.Windows.Forms.CheckBox endDateCheckBox;
        private System.Windows.Forms.CheckBox hireDateCheckBox;
        private System.Windows.Forms.CheckBox departmentCheckBox;
        private System.Windows.Forms.CheckBox roleCheckBox;
        private System.Windows.Forms.CheckBox addressCheckBox;
        private System.Windows.Forms.CheckBox salaryCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button enableAllButton;
        private System.Windows.Forms.DataGridView departmentsDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteDepartmentsButton;
        private System.Windows.Forms.Button updateDetailsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox departmentIdTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}