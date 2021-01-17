namespace MediaBazaar.Forms
{
    partial class NewUserForm
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
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassConfirmTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordTextBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(94, 78);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(136, 22);
            this.newPassTextBox.TabIndex = 0;
            // 
            // newPassConfirmTextBox
            // 
            this.newPassConfirmTextBox.Location = new System.Drawing.Point(94, 170);
            this.newPassConfirmTextBox.Name = "newPassConfirmTextBox";
            this.newPassConfirmTextBox.Size = new System.Drawing.Size(136, 22);
            this.newPassConfirmTextBox.TabIndex = 1;
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.BackColor = System.Drawing.Color.Teal;
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(75, 260);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(177, 67);
            this.ChangePasswordTextBox.TabIndex = 2;
            this.ChangePasswordTextBox.Text = "Change Password";
            this.ChangePasswordTextBox.UseVisualStyleBackColor = false;
            this.ChangePasswordTextBox.Click += new System.EventHandler(this.ChangePasswordTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChangePasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newPassConfirmTextBox);
            this.groupBox1.Controls.Add(this.newPassTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(226, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 379);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Time Login";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox newPassConfirmTextBox;
        private System.Windows.Forms.Button ChangePasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}