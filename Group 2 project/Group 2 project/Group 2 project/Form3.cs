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
            string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand query = new MySqlCommand ("select  * from dbi434661.credentials where username='" + this.tbEmail.Text+"' and password='"+this.tbPassword.Text+ "'",conDataBase);
            MySqlDataAdapter sda = new MySqlDataAdapter(query);

            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string comboboxitem = this.cmUsers.SelectedItem.ToString();

                //what happenes

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["username"].ToString() == comboboxitem)
                        {
                            MessageBox.Show("Welcome to your personal space" + dt.Rows[i][2]);

                            if (cmUsers.SelectedIndex == 0)
                            {
                                Administration adminpage = new Administration();
                                adminpage.Show();
                                this.Hide();

                            }
                            else if (cmUsers.SelectedIndex == 1)
                            {
                                Form5 form5 = new Form5();
                                form5.Show();
                                this.Hide();
                            }
                            else
                            {
                                Employeeselfservice employeeselfservice = new Employeeselfservice();
                                employeeselfservice.Show();
                                this.Hide();
                            }

                        }

                    }

                }
                else
                {

                    MessageBox.Show("Enter correct details");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            //sda.SelectCommand = cmdDataBase;
            //DataTable dbaTableset = new DataTable();
            //sda.Fill(dbaTableset);
            //BindingSource bSource = new BindingSource();

            //bSource.DataSource = dbaTableset;

            //cmUsers.DataSource = bSource;
            //sda.Update(dbaTableset);

            //string email = EmailBox.Text;
            //string pass = PasswordBox.Text;

            //try
            //{

            //    MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            //    MySqlCommand query = new MySqlCommand($"SELECT * FROM login WHERE email = '{email}'", conn);

            //    conn.Open();

            //    var reader = query.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string password = reader.GetString(2);
            //        if (password == pass)
            //        {
            //            LoginSuccessTextBox.Text = "Success";
            //            Admin admin = new Admin();

            //        }
            //        else
            //        {
            //            LoginSuccessTextBox.Text = "Fail";
            //        }
            //    }

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    LoginSuccessTextBox.Text = $"Error: {0}, {ex.ToString()}";
            //}
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
            else {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
