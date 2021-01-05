using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using MediaBazaarOOD_1.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarOOD_1.Forms
{
    public partial class Admin : Form
    {
        PersonManager personManager = new PersonManager();
        DepartmentManager departmentManager = new DepartmentManager();

        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fName = this.tbFirstName.Text;
            string lName = this.tbLastName.Text;
            int age = Convert.ToInt32(this.tbAge.Text);
            string gender = this.cmbGender.Text;
            string dName = this.cmbDepartmentName.Text;
            DateTime hireDate = Convert.ToDateTime(this.dtpHireDate.Text);
            //string endDate = this.dateTimePicker1.Text;
            int salary = Convert.ToInt32(this.tbSalary.Text);
            string address = this.tbAddress.Text;
            string role = this.cmbRole.Text;

            if (Regex.IsMatch(this.tbFirstName.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Invalid Name provided ! ! !");
            }
            else if (Regex.IsMatch(this.tbLastName.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Invalid Lastname provided ! ! !");
            }
            else if (Regex.IsMatch(tbAge.Text, @"^[0-9]{9}$") == false)
            {
                MessageBox.Show("Invalid Age provided ! ! !");
            }
            else
            {


                if (cmbRole.SelectedIndex == 0) // admin
                {
                    Person administrator = new Class.Admin(fName, lName, age, gender, dName, hireDate, salary, address, role);
                    //Person p = Class.Admin();

                    personManager.AddNewPerson(administrator);//we
                    PersonData.AddPerson(administrator);
                    MessageBox.Show(" Admin Succesfully added");
                }
                else
                {
                    MessageBox.Show("not added");
                }
                if (cmbRole.SelectedIndex == 1) // manager
                {
                    Person manager = new Class.Manager(fName, lName, age, gender, dName, hireDate, salary, address, role);
                    personManager.AddNewPerson(manager);
                    PersonData.AddPerson(manager);

                    MessageBox.Show
                        ("Manager Succesfully added");
                }
                else
                if (cmbRole.SelectedIndex == 2) // Employeee
                {

                    Person emp = new Class.Employee(fName, lName, age, gender, dName, hireDate, salary, address, role);
                    personManager.AddNewPerson(emp);
                    PersonData.AddPerson(emp);

                    MessageBox.Show
                        ("Employee Succesfully added");
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            this.Hide();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
