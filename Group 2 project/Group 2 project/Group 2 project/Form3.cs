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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string pass = PasswordBox.Text;

            try
            {
                
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
                MySqlCommand query = new MySqlCommand($"SELECT * FROM login WHERE email = '{email}'", conn);

                conn.Open();

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    string password = reader.GetString(2);
                    if (password == pass)
                    {
                        LoginSuccessTextBox.Text = "Success";
                    }
                    else
                    {
                        LoginSuccessTextBox.Text = "Fail";
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                LoginSuccessTextBox.Text = $"Error: {0}, {ex.ToString()}";
            }
        }
    }
}
