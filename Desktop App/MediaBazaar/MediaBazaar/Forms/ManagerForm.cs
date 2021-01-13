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
            Text = username;
        }






        private void scheduleOverviewDatePicker_ValueChanged(object sender, EventArgs e)
        {
            scheduleOverviewDataGrid.DataSource = scheduleManager.GetOverview(scheduleOverviewDatePicker.Value);
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = manualAssignGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
                scheduleManager.AddSchedule(scheduleDatePicker.Value, checkedButton.Text, personManager.GetIdFromFirstAndLastname(firstNameTextBox.Text, lastNameTextBox.Text));
        }

        private void autoAssignBtn_Click(object sender, EventArgs e)
        {
            //AutoScheduleAlgorithm algorithm = new AutoScheduleAlgorithm(personManager.GetEmployees(), dateTimePicker1.Value, dateTimePicker2.Value);
            //algorithm.AssignSchedules();
            //MessageBox.Show("Schedules Assigned.");
            MessageBox.Show("____");
        }
    }
}
