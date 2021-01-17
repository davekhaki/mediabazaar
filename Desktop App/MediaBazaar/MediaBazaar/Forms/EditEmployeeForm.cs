using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarOO.Forms;
using MediaBazaarOO.Logic;

namespace MediaBazaar.Forms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly PersonManager personManager = new PersonManager();
        private string username;
        public EditEmployeeForm(string username)
        {
            InitializeComponent();
            dtgEdit.DataSource = personManager.GetAllEmployees();
            dtgEdit.DefaultCellStyle.ForeColor = Color.Black;

            this.username = username;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gender = this.cmbGender.Text;
            string dpname = this.cmbDnameEdit.Text;
            DateTime dob = dateTimePicker1.Value;
            personManager.EditEmployeeInfo(Convert.ToInt32(tbIdEdit.Text), tbFnEdit.Text, tbLnEdit.Text, dob, gender, dpname, Convert.ToDateTime(this.dtpHireDate.Text), Convert.ToInt32(tbSalaryEdit.Text), this.tbAddressEdit.Text, this.cmbRole.Text);
            MessageBox.Show("Details Updated.");
        }

        private void dtgEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtgEdit.Rows[e.RowIndex];

                tbIdEdit.Text = dgvr.Cells["ID"].Value.ToString();

                tbFnEdit.Text = dgvr.Cells["FirstName"].Value.ToString();
                tbLnEdit.Text = dgvr.Cells["LastName"].Value.ToString();

                dateTimePicker1.Value = personManager.GetDob(Convert.ToInt32(tbIdEdit.Text));

                cmbGender.Text = dgvr.Cells["Gender"].Value.ToString();

                cmbDnameEdit.Text = dgvr.Cells["DepartmentName"].Value.ToString();

                dtpHireDate.Text = dgvr.Cells["HireDate"].Value.ToString();

                tbSalaryEdit.Text = dgvr.Cells["Salary"].Value.ToString();

                tbAddressEdit.Text = dgvr.Cells["Address"].Value.ToString();

                cmbRole.Text = dgvr.Cells["Role"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AdminForm(username);
            form.Show();
            this.Hide();
        }
    }
}
