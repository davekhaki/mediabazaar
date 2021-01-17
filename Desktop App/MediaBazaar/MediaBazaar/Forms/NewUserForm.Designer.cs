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
            this.SuspendLayout();
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(325, 114);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(100, 22);
            this.newPassTextBox.TabIndex = 0;
            // 
            // newPassConfirmTextBox
            // 
            this.newPassConfirmTextBox.Location = new System.Drawing.Point(325, 198);
            this.newPassConfirmTextBox.Name = "newPassConfirmTextBox";
            this.newPassConfirmTextBox.Size = new System.Drawing.Size(100, 22);
            this.newPassConfirmTextBox.TabIndex = 1;
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(291, 271);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(170, 60);
            this.ChangePasswordTextBox.TabIndex = 2;
            this.ChangePasswordTextBox.Text = "Change Password";
            this.ChangePasswordTextBox.UseVisualStyleBackColor = true;
            this.ChangePasswordTextBox.Click += new System.EventHandler(this.ChangePasswordTextBox_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePasswordTextBox);
            this.Controls.Add(this.newPassConfirmTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox newPassConfirmTextBox;
        private System.Windows.Forms.Button ChangePasswordTextBox;
    }
}