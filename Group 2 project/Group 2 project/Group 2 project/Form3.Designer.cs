namespace Group_2_project
{
    partial class Form3
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
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogIn.BackColor = System.Drawing.Color.Teal;
            this.pnlLogIn.Controls.Add(this.lblEmail);
            this.pnlLogIn.Controls.Add(this.lblPassword);
            this.pnlLogIn.Controls.Add(this.tbEmail);
            this.pnlLogIn.Controls.Add(this.tbPassword);
            this.pnlLogIn.Controls.Add(this.btnLogin);
            this.pnlLogIn.Controls.Add(this.btnSignUp);
            this.pnlLogIn.Location = new System.Drawing.Point(225, 96);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(553, 415);
            this.pnlLogIn.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(126, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(99, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(199, 69);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(185, 22);
            this.tbEmail.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(199, 112);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(185, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(199, 158);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(199, 224);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(185, 37);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1052, 555);
            this.Controls.Add(this.pnlLogIn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
    }
}