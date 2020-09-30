namespace Group_2_project
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.empDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeLoadBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empListForSchedule = new System.Windows.Forms.DataGridView();
            this.EveningBtn = new System.Windows.Forms.RadioButton();
            this.AfternoonBtn = new System.Windows.Forms.RadioButton();
            this.morningBtn = new System.Windows.Forms.RadioButton();
            this.dateTimeShiftPicker = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmpIdTextBox = new System.Windows.Forms.TextBox();
            this.GetShiftsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ShiftListBox = new System.Windows.Forms.ListBox();
            this.SelectedEmpTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListForSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Employee";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.White;
            this.Homebtn.Location = new System.Drawing.Point(12, 114);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(134, 36);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 719);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(233, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 598);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.empDataGrid);
            this.panel4.Controls.Add(this.employeeLoadBtn);
            this.panel4.Location = new System.Drawing.Point(34, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 577);
            this.panel4.TabIndex = 7;
            // 
            // empDataGrid
            // 
            this.empDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGrid.Location = new System.Drawing.Point(34, 77);
            this.empDataGrid.Name = "empDataGrid";
            this.empDataGrid.RowHeadersWidth = 51;
            this.empDataGrid.RowTemplate.Height = 24;
            this.empDataGrid.Size = new System.Drawing.Size(644, 341);
            this.empDataGrid.TabIndex = 9;
            this.empDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDataGrid_CellContentClick);
            // 
            // employeeLoadBtn
            // 
            this.employeeLoadBtn.Location = new System.Drawing.Point(97, 21);
            this.employeeLoadBtn.Name = "employeeLoadBtn";
            this.employeeLoadBtn.Size = new System.Drawing.Size(218, 29);
            this.employeeLoadBtn.TabIndex = 8;
            this.employeeLoadBtn.Text = "Load Employees";
            this.employeeLoadBtn.UseVisualStyleBackColor = true;
            this.employeeLoadBtn.Click += new System.EventHandler(this.employeeLoadBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scheduling";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(34, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 591);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SelectedEmpTxt);
            this.groupBox2.Controls.Add(this.empListForSchedule);
            this.groupBox2.Controls.Add(this.EveningBtn);
            this.groupBox2.Controls.Add(this.AfternoonBtn);
            this.groupBox2.Controls.Add(this.morningBtn);
            this.groupBox2.Controls.Add(this.dateTimeShiftPicker);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(333, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 521);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // empListForSchedule
            // 
            this.empListForSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empListForSchedule.Location = new System.Drawing.Point(6, 64);
            this.empListForSchedule.Name = "empListForSchedule";
            this.empListForSchedule.RowHeadersWidth = 51;
            this.empListForSchedule.RowTemplate.Height = 24;
            this.empListForSchedule.Size = new System.Drawing.Size(448, 202);
            this.empListForSchedule.TabIndex = 13;
            this.empListForSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empListForSchedule_CellContentClick);
            // 
            // EveningBtn
            // 
            this.EveningBtn.AutoSize = true;
            this.EveningBtn.Location = new System.Drawing.Point(227, 419);
            this.EveningBtn.Name = "EveningBtn";
            this.EveningBtn.Size = new System.Drawing.Size(80, 21);
            this.EveningBtn.TabIndex = 12;
            this.EveningBtn.TabStop = true;
            this.EveningBtn.Text = "Evening";
            this.EveningBtn.UseVisualStyleBackColor = true;
            // 
            // AfternoonBtn
            // 
            this.AfternoonBtn.AutoSize = true;
            this.AfternoonBtn.Location = new System.Drawing.Point(227, 392);
            this.AfternoonBtn.Name = "AfternoonBtn";
            this.AfternoonBtn.Size = new System.Drawing.Size(91, 21);
            this.AfternoonBtn.TabIndex = 11;
            this.AfternoonBtn.TabStop = true;
            this.AfternoonBtn.Text = "Afternoon";
            this.AfternoonBtn.UseVisualStyleBackColor = true;
            // 
            // morningBtn
            // 
            this.morningBtn.AutoSize = true;
            this.morningBtn.Location = new System.Drawing.Point(227, 365);
            this.morningBtn.Name = "morningBtn";
            this.morningBtn.Size = new System.Drawing.Size(80, 21);
            this.morningBtn.TabIndex = 10;
            this.morningBtn.TabStop = true;
            this.morningBtn.Text = "Morning";
            this.morningBtn.UseVisualStyleBackColor = true;
            this.morningBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimeShiftPicker
            // 
            this.dateTimeShiftPicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimeShiftPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeShiftPicker.Location = new System.Drawing.Point(189, 318);
            this.dateTimeShiftPicker.Name = "dateTimeShiftPicker";
            this.dateTimeShiftPicker.Size = new System.Drawing.Size(271, 22);
            this.dateTimeShiftPicker.TabIndex = 9;
            this.dateTimeShiftPicker.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 57);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add Shift";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select a date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an employee:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmpIdTextBox);
            this.groupBox1.Controls.Add(this.GetShiftsBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ShiftListBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EmpIdTextBox
            // 
            this.EmpIdTextBox.Location = new System.Drawing.Point(89, 58);
            this.EmpIdTextBox.Name = "EmpIdTextBox";
            this.EmpIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmpIdTextBox.TabIndex = 3;
            this.EmpIdTextBox.Text = "Employee ID";
            // 
            // GetShiftsBtn
            // 
            this.GetShiftsBtn.Location = new System.Drawing.Point(169, 114);
            this.GetShiftsBtn.Name = "GetShiftsBtn";
            this.GetShiftsBtn.Size = new System.Drawing.Size(75, 23);
            this.GetShiftsBtn.TabIndex = 2;
            this.GetShiftsBtn.Text = "GetShifts";
            this.GetShiftsBtn.UseVisualStyleBackColor = true;
            this.GetShiftsBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Your upcoming shifts";
            // 
            // ShiftListBox
            // 
            this.ShiftListBox.FormattingEnabled = true;
            this.ShiftListBox.ItemHeight = 16;
            this.ShiftListBox.Location = new System.Drawing.Point(26, 162);
            this.ShiftListBox.Name = "ShiftListBox";
            this.ShiftListBox.Size = new System.Drawing.Size(240, 228);
            this.ShiftListBox.TabIndex = 0;
            this.ShiftListBox.SelectedIndexChanged += new System.EventHandler(this.ShiftListBox_SelectedIndexChanged);
            // 
            // SelectedEmpTxt
            // 
            this.SelectedEmpTxt.Location = new System.Drawing.Point(189, 283);
            this.SelectedEmpTxt.Name = "SelectedEmpTxt";
            this.SelectedEmpTxt.Size = new System.Drawing.Size(237, 22);
            this.SelectedEmpTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Employee:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListForSchedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button employeeLoadBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ShiftListBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox EmpIdTextBox;
        private System.Windows.Forms.Button GetShiftsBtn;
        private System.Windows.Forms.DateTimePicker dateTimeShiftPicker;
        private System.Windows.Forms.RadioButton EveningBtn;
        private System.Windows.Forms.RadioButton AfternoonBtn;
        private System.Windows.Forms.RadioButton morningBtn;
        private System.Windows.Forms.DataGridView empDataGrid;
        private System.Windows.Forms.DataGridView empListForSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectedEmpTxt;
    }
}