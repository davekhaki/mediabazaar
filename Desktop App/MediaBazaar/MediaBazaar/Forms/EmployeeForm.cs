using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Logic;
using MediaBazaarOO.Logic;

namespace MediaBazaarOO.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly ScheduleManager scheduleManager = new ScheduleManager();
        private readonly PersonManager personManager = new PersonManager();
        private readonly RequestManager requestManager = new RequestManager();
        private readonly StockManager stockManager = new StockManager();
        private readonly string Username;
        public EmployeeForm(string username)
        {
            InitializeComponent();
            Username = username;
            Text = "Employee | " + Username;

            requestDataGrid.DataSource = requestManager.GetRequests();
            stockDataGrid.DataSource = stockManager.GetAllStock();

            checkBox2.Checked = personManager.GetPreference(personManager.GetIdFromUsername(username))[0];
            checkBox3.Checked = personManager.GetPreference(personManager.GetIdFromUsername(username))[1];
            checkBox4.Checked = personManager.GetPreference(personManager.GetIdFromUsername(username))[2];
        }



        private void signOutBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void scheduleMonthCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            scheduleDataGrid.DataSource = scheduleManager.GetSchedulesForDay(scheduleMonthCalender.SelectionRange.Start, personManager.GetIdFromUsername(Username));
            scheduleDataGrid.Columns.Remove("empId");
            scheduleDataGrid.Columns.Remove("Day");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (requestDataGrid.SelectedRows.Count == 0) return;

            requestManager.CompleteRequest(Convert.ToInt32(requestDataGrid.SelectedRows[0].Cells["Id"].Value.ToString()));
            MessageBox.Show("Request completed.");
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            personManager.ChangePassword(Username, tbOldPassword.Text, tbNewPassword.Text);
            tbOldPassword.Text = "";
            tbNewPassword.Text = "";

            MessageBox.Show("Password Changed");

            //logs the user out so they can login with their new password
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void updatePreferenceBtn_Click(object sender, EventArgs e)
        {
            personManager.UpdatePreference(Text, checkBox2.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
            MessageBox.Show("Preference Updated.");
        }

        private void updateStockBtn_Click(object sender, EventArgs e)
        {
            stockManager.UpdateProduct(Convert.ToInt32(tbProductId.Text), Convert.ToInt32(tbQuantity.Text));
            stockDataGrid.DataSource = stockManager.GetAllStock();
            MessageBox.Show("Quantity Changed");
        }

        private void stockDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (stockDataGrid.SelectedRows.Count == 0) return;
            tbProductId.Text = stockDataGrid.SelectedRows[0].Cells["ProductId"].Value.ToString();
        }
    }
}
