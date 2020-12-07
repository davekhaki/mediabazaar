namespace Media_Bazaar
{
    partial class LoginForm
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.seePasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(886, 461);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(238, 22);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameInput_KeyPress);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(886, 526);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(238, 22);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(890, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your login details";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(886, 599);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(237, 50);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // seePasswordCheckbox
            // 
            this.seePasswordCheckbox.AutoSize = true;
            this.seePasswordCheckbox.Location = new System.Drawing.Point(1150, 527);
            this.seePasswordCheckbox.Name = "seePasswordCheckbox";
            this.seePasswordCheckbox.Size = new System.Drawing.Size(119, 21);
            this.seePasswordCheckbox.TabIndex = 6;
            this.seePasswordCheckbox.Text = "See password";
            this.seePasswordCheckbox.UseVisualStyleBackColor = true;
            this.seePasswordCheckbox.CheckedChanged += new System.EventHandler(this.seePasswordCheckbox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1906, 979);
            this.Controls.Add(this.seePasswordCheckbox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox seePasswordCheckbox;
    }
}

