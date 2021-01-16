using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Logic;
using MediaBazaarOO.Logic;

namespace MediaBazaarOO.Forms
{
    public partial class ManagerForm : Form
    {
        private readonly ScheduleManager scheduleManager = new ScheduleManager();
        private readonly PersonManager personManager = new PersonManager();
        public ManagerForm(string username)
        {
            InitializeComponent();
            Text = "Manager | " + username;
            
        }



        private void assignBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = manualAssignGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
                scheduleManager.AddSchedule(scheduleDatePicker.Value, checkedButton.Text, personManager.GetIdFromFirstAndLastname(firstNameTextBox.Text, lastNameTextBox.Text));
        }

        private void autoAssignBtn_Click(object sender, EventArgs e)
        {
            var algorithm = new AutoScheduleAlgorithm(dateTimePicker1.Value, dateTimePicker2.Value);
            algorithm.AssignSchedules();
            MessageBox.Show("Schedules Assigned.");
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void scheduleOverviewCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            scheduleOverviewDataGrid.DataSource = scheduleManager.GetOverview(personManager, scheduleOverviewCalendar.SelectionRange.Start.Date);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.DataSource = scheduleManager.GetOverview(personManager, scheduleOverviewCalendar.SelectionRange.Start.Date);
        }

        private void idCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.Columns["Employee ID"].Visible = !scheduleOverviewDataGrid.Columns["Employee ID"].Visible;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.Columns["First Name"].Visible = !scheduleOverviewDataGrid.Columns["First Name"].Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.Columns["Last Name"].Visible = !scheduleOverviewDataGrid.Columns["Last Name"].Visible;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.Columns["Time"].Visible = !scheduleOverviewDataGrid.Columns["Time"].Visible;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.Columns["Day"].Visible = !scheduleOverviewDataGrid.Columns["Day"].Visible;
        }
    }
}
