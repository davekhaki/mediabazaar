using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Media_Bazaar_Logic;
using Media_Bazaar_Logic.Entities;
using static Media_Bazaar_Logic.DataGridLogic.DataGridFilter;

namespace Media_Bazaar
{
    public sealed partial class AdminForm : Form
    {
        private readonly User user;
        private ManagementSystem ms;
        private DataTable dt;
        public AdminForm(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            ms = new ManagementSystem();

            Text = $@"{user.FirstName} {user.LastName}";

            dt = ToDataTable(ms.GetUsers().ToList());
            employeeDataGrid.DataSource = dt;
            SetStandardColumns(dt);

            var departmentDataTable = ToDataTable(ms.GetDepartments().ToList());
            departmentsDataGrid.DataSource = departmentDataTable;

        }

        private void SetStandardColumns(DataTable dataTable)
        {
            dataTable.Columns.Remove("username");
            dataTable.Columns.Remove("password");

            dataTable.Columns["Id"].ColumnName = "ID";
            dataTable.Columns["FirstName"].ColumnName = "First Name";
            dataTable.Columns["LastName"].ColumnName = "Last Name";
            dataTable.Columns["HireDate"].ColumnName = "Employment Date";
            dataTable.Columns["EndDate"].ColumnName = "Unemployment Date";

            FilterColumn(employeeDataGrid, "Age");
            FilterColumn(employeeDataGrid, "Gender");
            FilterColumn(employeeDataGrid, "Unemployment Date");
            FilterColumn(employeeDataGrid, "Address");
            FilterColumn(employeeDataGrid, "Role");
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e) // event happens when ENTER key is pressed
        {
            if (e.KeyChar != (char) 13) return; // 13 = ENTER
            var dv = dt.DefaultView;
            dv.RowFilter = string.Format("[First Name] LIKE '%{0}%' or [Last Name] LIKE '%{0}%'", searchBox.Text); //does a rough filter (either first or lastname can contain the given string)
            e.Handled = true; // stops the DING sounds (annoying)
        }

        public static DataTable ToDataTable<T>(IList<T> data) //method that converts a list with custom type to data table
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }

        #region Checkbox/filters

        private void idCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Id");
        }

        private void firstNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "First Name");
        }

        private void lastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Last Name");
        }

        private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Age");
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Gender");
        }

        private void departmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Department");
        }

        private void hireDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Employment Date");
        }

        private void endDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Unemployment Date");
        }

        private void salaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Salary");
        }

        private void addressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Address");
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Email");
        }

        private void roleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterColumn(employeeDataGrid, "Role");
        }

        private void enableAllButton_Click(object sender, EventArgs e)
        {
            foreach (var c in filtersGroupBox.Controls)
            {
                if (!(c is CheckBox)) continue;
                var cb = (CheckBox)c;
                cb.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var c in filtersGroupBox.Controls)
            {
                if (!(c is CheckBox)) continue;
                var cb = (CheckBox)c;
                cb.Checked = false;
            }
        }

        #endregion

        #region Department Overview Tab

        private string oldName;
        private void departmentsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = departmentsDataGrid.Rows[e.RowIndex];
            departmentIdTextBox.Text = row.Cells["id"].Value.ToString();
            departmentNameTextBox.Text = row.Cells["name"].Value.ToString();
            oldName = row.Cells["name"].Value.ToString();
        }
        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            ms.UpdateDetails(int.Parse(departmentIdTextBox.Text), oldName, departmentNameTextBox.Text);
            var row = departmentsDataGrid.CurrentRow;
            if (row != null) row.Cells["name"].Value = departmentNameTextBox.Text;
        }

        #endregion



    }
}
