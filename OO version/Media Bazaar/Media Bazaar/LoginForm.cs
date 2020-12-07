using System;
using System.Windows.Forms;
using Media_Bazaar_Logic;
using Media_Bazaar_Logic.Entities;

namespace Media_Bazaar
{
    public partial class LoginForm : Form
    {
        private readonly ManagementSystem ms;
        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ms = new ManagementSystem();
        }

        private void seePasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = !passwordInput.UseSystemPasswordChar;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return; // 13 = ENTER
            e.Handled = true;
            LoginMethod();
        }

        private void passwordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return; // 13 = ENTER
            e.Handled = true;
            LoginMethod();
        }

        private void LoginMethod()
        {
            if (!ms.Login(usernameInput.Text, passwordInput.Text)) return;
            var emp = (Employee)ms.GetDetails(usernameInput.Text, passwordInput.Text);
            if (emp == null) throw new ArgumentNullException(nameof(emp));
            var role = emp.Role;
            switch (role)
            {
                case "Employee":
                    var employeeForm = new EmployeeForm(emp);
                    employeeForm.Show();
                    this.Hide();
                    break;
                case "Manager":
                    var managerForm = new ManagerForm();
                    managerForm.Show();
                    this.Hide();
                    break;
                case "Admin":
                    var adminForm = new AdminForm(emp);
                    adminForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
