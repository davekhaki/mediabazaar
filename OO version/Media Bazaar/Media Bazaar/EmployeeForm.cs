using Media_Bazaar_Logic.Entities;
using Media_Bazaar_Logic;
using System;
using System.Linq;
using System.Windows.Forms;
using Media_Bazaar_Logic.DataGridLogic;

namespace Media_Bazaar
{
    public partial class EmployeeForm : Form
    {
        private ManagementSystem ms = new ManagementSystem();
        private User user;
        public EmployeeForm(User u)
        {
            InitializeComponent();
            user = u;            
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; //full screens the form
            Text = $@"{user.FirstName} {user.LastName}"; //puts full name on top of the form

            scheduleCalendar.BoldedDates = ms.GetScheduledDates((Employee)user);
        }

        #region Schedule Tab

        private void scheduleCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            var dt = ListToDataTableConverter.ToDataTable(ms.GetScheduleInfo((Employee)user, e.Start));
            dt.Columns.Remove("empId");
            scheduleDataGrid.DataSource = dt;
        }

        #endregion

        #region Settings Tab

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ms.ChangePassword(user, oldPasswordTextBox.Text, newPasswordTextBox.Text, newPasswordConfirmTextBox.Text);
            oldPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            newPasswordConfirmTextBox.Clear();
        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            ms.ChangeUsername(user, currentUsernameTextBox.Text, newUsernameTextBox.Text);
            currentUsernameTextBox.Clear();
            newUsernameTextBox.Clear();
        }

        #endregion

        private void signOutButton_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
