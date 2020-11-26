using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ArtichokeData.LoginManager LoginManager = new ArtichokeData.LoginManager();
      

            if(LoginManager.Login(tbEmail.Text, tbPassword.Text))
            {
                switch (LoginManager.GetRole(tbEmail.Text)) {
                    case "Manager":
                        Manager form5 = new Manager();
                        form5.Show();
                        this.Hide();
                        break;
                    case "Employee":
                        Employeeselfservice employeeselfservice = new Employeeselfservice(tbEmail.Text);
                        employeeselfservice.Show();
                        this.Hide();
                        break;
                    case "Admin":
                        Administration adminpage = new Administration();
                        adminpage.Show();
                        this.Hide();
                        break;

                }
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else tbPassword.UseSystemPasswordChar = true;        
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
