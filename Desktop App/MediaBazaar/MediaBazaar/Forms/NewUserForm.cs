using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarOO.Forms;
using MediaBazaarOO.Logic;

namespace MediaBazaar.Forms
{
    public partial class NewUserForm : Form
    {
        private readonly PersonManager personManager = new PersonManager();
        private string username;
        private string password;
        public NewUserForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            Text = "First Login | " + username;
        }

        private void ChangePasswordTextBox_Click(object sender, EventArgs e)
        {
            if (newPassTextBox.Text == newPassConfirmTextBox.Text)
            {
                personManager.ChangePassword(username, password, newPassTextBox.Text);
                personManager.CompleteFirstLogin(username);

                var form = new LoginForm();
                form.Show();
                this.Hide();
            }
            
        }
    }
}
