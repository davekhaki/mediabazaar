using MediaBazaarOOD_1.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarOOD_1.Forms
{
    public partial class Edit : Form
    {

        PersonManager personManager = new PersonManager();
        DepartmentManager departmentManager = new DepartmentManager();
        StatisticsManager sm = new StatisticsManager();
        public Edit()
        {
            InitializeComponent();
            AutoFillPersonGridEdit();
            dtgEdit.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void AutoFillPersonGridEdit()
        {
            this.dtgEdit.DataSource = personManager.GetAllPersons();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            personManager.EditEmployeeInfo(tbIdEdit.Text, tbFnEdit.Text, Convert.ToInt32(tbLnEdit.Text), this.cmbGender.Text,this.cmbDnameEdit.Text, Convert.ToDateTime(this.dtpHireDate.Text), Convert.ToInt32(tbSalaryEdit), this.tbAddressEdit.Text,this.cmbRole.Text);
        }

        private void tbSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtgEdit.Rows[e.RowIndex];
                tbFnEdit.Text = dgvr.Cells["FirstName"].Value.ToString();
                tbLnEdit.Text = dgvr.Cells["LastName"].Value.ToString();
                tbAgeEdit.Text = dgvr.Cells["Age"].Value.ToString();
                this.cmbGender.Text = dgvr.Cells["Gender"].Value.ToString();
                this.cmbDnameEdit.Text = dgvr.Cells["DepartmentName"].Value.ToString();
                //  tbFnEdit.Text = dgvr.Cells["FirstName"].Value.ToString();
                this.dtpHireDate.Text = dgvr.Cells["HireDate"].Value.ToString();
                tbSalaryEdit.Text = dgvr.Cells["Salary"].Value.ToString();
                this.tbAddressEdit.Text = dgvr.Cells["Address"].Value.ToString();
                this.cmbRole.Text = dgvr.Cells["Role"].Value.ToString();


            }
        }
    }
}
