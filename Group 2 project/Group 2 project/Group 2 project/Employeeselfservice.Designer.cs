namespace Group_2_project
{
    partial class Employeeselfservice
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridViewSchedule);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1199, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Shift Schedules";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1199, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Requests";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.dataGridViewStock);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(566, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 532);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Location = new System.Drawing.Point(245, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(362, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(115, 494);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(91, 22);
            this.tbQuantity.TabIndex = 18;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStock.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(611, 414);
            this.dataGridViewStock.TabIndex = 10;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(115, 466);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(91, 22);
            this.tbID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ProductID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDone);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 532);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Notification";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Green;
            this.btnDone.Location = new System.Drawing.Point(39, 477);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(404, 49);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(48, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1207, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(261, 49);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(661, 348);
            this.dataGridViewSchedule.TabIndex = 0;
            this.dataGridViewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(38, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employeeselfservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1267, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "Employeeselfservice";
            this.Text = "Employeeselfservice";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button button2;
    }
}