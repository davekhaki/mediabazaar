using iTextSharp.text;
using iTextSharp.text.pdf;
using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using MediaBazaarOOD_1.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        void ExportDepsToPdf(PdfPTable pdfptable, String strPdfPath, string strHeader)
        {

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Write the table
            PdfPTable table = new PdfPTable(this.dgViewAllDepartments.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int j = 0; j < dgViewAllDepartments.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgViewAllDepartments.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            //table Data
            for (int i = 0; i < dgViewAllDepartments.Columns.Count; i++)
            {
                for (int k = 0; k < dgViewAllDepartments.Columns.Count; k++)
                {
                    if (dgViewAllDepartments[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgViewAllDepartments[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();

        }
        void ExportStockToPdf(PdfPTable pdfptable, String strPdfPath, string strHeader)
        {

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Write the table
            PdfPTable table = new PdfPTable(this.dgViewAllStock.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int j = 0; j < dgViewAllStock.Columns.Count; j++)
            {
                table.AddCell(new Phrase(this.dgViewAllStock.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            //table Data
            for (int i = 0; i < dgViewAllStock.Columns.Count; i++)
            {
                for (int k = 0; k < dgViewAllStock.Columns.Count; k++)
                {
                    if (dgViewAllEmployees[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgViewAllStock[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();

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

        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                
                PdfPTable t = new PdfPTable(this.dgViewAllDepartments.Columns.Count);
                
                ExportDepsToPdf(t, @"C:\Users\Gebruiker\Desktop\deps.pdf", "Departments");
            }
            else if (radioButton2.Checked)
            {
                
                PdfPTable t = new PdfPTable(this.dgViewAllEmployees.Columns.Count);
                
                ExportStockToPdf(t, @"C:\Users\Gebruiker\Desktop\STOCK.pdf", "stc");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgViewAllEmployees.Columns["ID"].Visible = true;
            dgViewAllEmployees.Columns["FirstName"].Visible = true;


            dgViewAllEmployees.Columns["LastName"].Visible = true;


            dgViewAllEmployees.Columns["Age"].Visible = true;


            dgViewAllEmployees.Columns["Gender"].Visible = true;

            dgViewAllEmployees.Columns["DepartmentName"].Visible = true;


            dgViewAllEmployees.Columns["Salary"].Visible = true;


            dgViewAllEmployees.Columns["Address"].Visible = true;


            dgViewAllEmployees.Columns["Role"].Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgViewAllEmployees.Columns["ID"].Visible = false;
            dgViewAllEmployees.Columns["FirstName"].Visible = false;


            dgViewAllEmployees.Columns["LastName"].Visible = false;


            dgViewAllEmployees.Columns["Age"].Visible = false;


            dgViewAllEmployees.Columns["Gender"].Visible = false;

            dgViewAllEmployees.Columns["DepartmentName"].Visible = false;


            dgViewAllEmployees.Columns["Salary"].Visible = false;


            dgViewAllEmployees.Columns["Address"].Visible = false;


            dgViewAllEmployees.Columns["Role"].Visible = false;

        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            dgViewAllEmployees.DataSource = personManager.GetAllPersons();
        }
    }
}
