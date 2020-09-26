namespace Group_2_project
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.loadStockBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPname = new System.Windows.Forms.TextBox();
            this.tbPprice = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Location = new System.Drawing.Point(-1, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 731);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Employee";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.White;
            this.Homebtn.Location = new System.Drawing.Point(12, 114);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(134, 32);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.tbQuantity);
            this.panel4.Controls.Add(this.tbBrand);
            this.panel4.Controls.Add(this.tbPprice);
            this.panel4.Controls.Add(this.tbPname);
            this.panel4.Controls.Add(this.tbId);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridViewStock);
            this.panel4.Controls.Add(this.loadStockBtn);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Addbtn);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(298, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 591);
            this.panel4.TabIndex = 8;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(41, 98);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(239, 394);
            this.dataGridViewStock.TabIndex = 9;
            // 
            // loadStockBtn
            // 
            this.loadStockBtn.Location = new System.Drawing.Point(41, 509);
            this.loadStockBtn.Name = "loadStockBtn";
            this.loadStockBtn.Size = new System.Drawing.Size(239, 41);
            this.loadStockBtn.TabIndex = 8;
            this.loadStockBtn.Text = "Load Stock";
            this.loadStockBtn.UseVisualStyleBackColor = true;
            this.loadStockBtn.Click += new System.EventHandler(this.loadStockBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock Inventory";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(422, 385);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(235, 38);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(422, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Request";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ProductId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ProductName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ProductPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(470, 98);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 15;
            // 
            // tbPname
            // 
            this.tbPname.Location = new System.Drawing.Point(479, 159);
            this.tbPname.Name = "tbPname";
            this.tbPname.Size = new System.Drawing.Size(100, 22);
            this.tbPname.TabIndex = 16;
            // 
            // tbPprice
            // 
            this.tbPprice.Location = new System.Drawing.Point(479, 208);
            this.tbPprice.Name = "tbPprice";
            this.tbPprice.Size = new System.Drawing.Size(100, 22);
            this.tbPprice.TabIndex = 17;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(479, 265);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 18;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(479, 318);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbQuantity.TabIndex = 19;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button loadStockBtn;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbPprice;
        private System.Windows.Forms.TextBox tbPname;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}