using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Forms;
using MediaBazaarOO.Logic;

namespace MediaBazaarOO.Forms
{
    public partial class LoginForm : Form
    {
        private readonly PersonManager personManager = new PersonManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (personManager.ValidLogin(usernameTextBox.Text, passwordTextBox.Text))
            {
                if (personManager.GetNewUser(usernameTextBox.Text) == 1)
                {
                    var form = new NewUserForm(usernameTextBox.Text, passwordTextBox.Text);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    switch (personManager.GetRole(usernameTextBox.Text))
                    {
                        case "Manager":
                            var form = new ManagerForm(usernameTextBox.Text);
                            form.Show();
                            this.Hide();
                            break;
                        case "Admin":
                            var formAdmin = new AdminForm(usernameTextBox.Text);
                            formAdmin.Show();
                            this.Hide();
                            break;
                        case "Employee":
                            var formEmployee = new EmployeeForm(usernameTextBox.Text);
                            formEmployee.Show();
                            this.Hide();
                            break;
                    }
                }
            }
            else MessageBox.Show("Login Failed.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return; // 13 = ENTER
            e.Handled = true;
            loginBtn_Click(new object(), new EventArgs());

        }
    }
}
