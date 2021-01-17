using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Entities;
using MediaBazaar.Logic;
using MediaBazaarOO.Logic;

namespace MediaBazaarOO.Forms
{
    public partial class ManagerForm : Form
    {
        private readonly ScheduleManager scheduleManager = new ScheduleManager();
        private readonly PersonManager personManager = new PersonManager();
        private readonly StockManager stockManager = new StockManager();
        private readonly RequestManager requestManager = new RequestManager();
        public ManagerForm(string username)
        {
            InitializeComponent();
            Text = "Manager | " + username;

            dataGridView3.DataSource = stockManager.GetAllStock();
            dataGridView2.DataSource = stockManager.GetUnderStocked();

            dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            scheduleOverviewDataGrid.DefaultCellStyle.ForeColor = Color.Black;
        }



        private void assignBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = manualAssignGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
                scheduleManager.AddSchedule(scheduleDatePicker.Value, checkedButton.Text, personManager.GetIdFromFirstAndLastname(firstNameTextBox.Text, lastNameTextBox.Text));
            MessageBox.Show("Schedule Assigned");
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView3.Rows[e.RowIndex];
            tbId.Text = row.Cells["ProductID"].Value.ToString();
            tbProductName.Text = row.Cells["ProductName"].Value.ToString();
            tbPrice.Text = row.Cells["ProductPrice"].Value.ToString();
            tbBrand.Text = row.Cells["Brand"].Value.ToString();
            tbQuantuity.Text = row.Cells["ProductQuantity"].Value.ToString();
            tbMinimumQuantity.Text = row.Cells["MinProductQuantity"].Value.ToString();
            string requestStocking = row.Cells["ProductQuantity"].Value.ToString(); ;
            // restock = row.Cells["Quantity"].Value.ToString();
            //tbMinimumQuantity.Text = row.Cells["MinimumQuantity"].Value.ToString();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbProductName.Text))
            requestManager.AddRequest(tbProductName.Text);
            MessageBox.Show("Request Sent");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stockManager.DeleteProduct((Convert.ToInt32(tbId.Text)));
            stockManager.RefreshStock();
            dataGridView3.DataSource = stockManager.GetAllStock();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            stockManager.AddProduct(new Product(tbProductName.Text, Convert.ToInt32(tbPrice.Text), tbBrand.Text, Convert.ToInt32(tbQuantuity.Text)));
            stockManager.RefreshStock();
            dataGridView3.DataSource = stockManager.GetAllStock();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            stockManager.EditStock(Convert.ToInt32(tbId.Text), tbProductName.Text, Convert.ToInt32(tbPrice.Text), tbBrand.Text, Convert.ToInt32(tbQuantuity.Text), Convert.ToInt32(tbMinimumQuantity.Text));
            stockManager.RefreshStock();
            dataGridView3.DataSource = stockManager.GetAllStock();
        }
    }
}
