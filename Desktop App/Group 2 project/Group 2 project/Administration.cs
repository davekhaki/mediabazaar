using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group_2_project
{
    public partial class Administration : Form
    {
        ArtichokeData.EmployeeManager employeeManager = new ArtichokeData.EmployeeManager();
        ArtichokeData.DepartmentManager departmentManager = new ArtichokeData.DepartmentManager();

        ArtichokeLogic.DataGridFilterLogic filter = new ArtichokeLogic.DataGridFilterLogic();
        ArtichokeLogic.MailLogic MailManager = new ArtichokeLogic.MailLogic();

        int empPageNumber = 1;
        public Administration()
        {
            InitializeComponent();

            employeeManager.GetAllEmployees(dShow, empPageNumber);
            

            departmentManager.GetAllDepartments(dgDepartments);

            FillEmployeeIds();
            ShowDepartmentNames();

            dShow.DefaultCellStyle.ForeColor = Color.Black;
            dShow.RowHeadersVisible = false;
            dgDepartments.DefaultCellStyle.ForeColor = Color.Black;

            pageNumberTextBox.Text = empPageNumber.ToString();

            autoLoadAgeChart();
            autoLoadSalaryChart();
            autoLoadGenderChart();
            autoLoadEmployeesChart();
            autoLoadSchedulesChart();

            AddCheckBoxes();
            this.ApplyStandardFilter();
        }

        private void ShowDepartmentNames()
        {
            foreach(string name in departmentManager.GetAllDepartmentNames())
            {
                cmDeptIds.Items.Add(name);
            }
        }

        void autoLoadAgeChart()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "SELECT DepartmentName, AVG(Age) AS 'avgAge' FROM employee GROUP BY DepartmentName";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.chart3.Series["Age"].Points.AddXY(reader.GetString("DepartmentName"), reader.GetInt32("avgAge"));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


        }
        void autoLoadSalaryChart()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "SELECT DepartmentName, SUM(Salary) AS 'totalSalary' FROM employee GROUP BY DepartmentName";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.chart6.Series["Salary"].Points.AddXY(reader.GetString("DepartmentName"), reader.GetInt32("totalSalary"));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }
        void autoLoadGenderChart()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "SELECT Gender, COUNT(Gender) AS 'countGender' FROM employee GROUP BY Gender";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.chart4.Series["Gender"].Points.AddXY(reader.GetString("Gender"), reader.GetInt32("countGender"));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }
        void autoLoadEmployeesChart()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "SELECT DepartmentName, COUNT(ID) AS 'totalEmployees' FROM employee GROUP BY DepartmentName";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.chart1.Series["Departments"].Points.AddXY(reader.GetString("DepartmentName"), reader.GetInt32("totalEmployees"));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        void autoLoadSchedulesChart()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "SELECT concat(e.FirstName,' ', e.LastName) AS 'Employee Name', COUNT(s.EmployeeID) AS 'Shifts Worked' FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID GROUP BY e.FirstName";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.chart2.Series["Employee Name"].Points.AddXY(reader.GetString("Employee Name"), reader.GetInt32("Shifts Worked"));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        void ClearBoxes()
        {

            tbDeptName.Clear();
            tbFn.Clear();
            tbId.Clear();
            tbSn.Clear();
            tbSal.Clear();
            tbAge.Clear();
            cmbGender.Text = "";
            cmDeptNames.Text = "";
            tbSal.Clear();
            tbAdd.Clear();
            cmbRole.Text = "";

        }
        void FillEmployeeIds()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "select * from dbi434661.employee;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    this.cmeIds.Items.Add(name);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckExistingEmployee()
        {
            bool doesExist = false;
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = $"SELECT * FROM employee WHERE ID = '{tbId.Text}'";

            MySqlCommand command = new MySqlCommand(query, conn);

            conn.Open();
            int rows = command.ExecuteNonQuery();
            if (rows == 0 || rows == -1)
            {
                doesExist = false;

            }
            else
            {
                doesExist = true;

            }

            conn.Close();
            return doesExist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if there a inputs
            if (string.IsNullOrEmpty(tbFn.Text) || string.IsNullOrEmpty(tbSn.Text))
            {
                MessageBox.Show("Please fill in all the details.");
                return;
            }

            if (CheckExistingEmployee() == true)
            {
                MessageBox.Show("A previously selected employee's ID cannot be used");
                return;
            }

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");

            string firstName = tbFn.Text;
            string lastName = tbSn.Text;
            int salary = int.Parse(tbSal.Text);

            string query = "insert into dbi434661.employee(Firstname,LastName,Age,Gender,DepartmentName" +
                ",HireDate,Salary,Adress,Role)values('" + this.tbFn.Text + "','" + this.tbSn.Text + "','" + this.tbAge.Text + "','" + this.cmbGender.Text + "','" + this.cmDeptNames.Text + "','" + this.dateTimePicker1.Text + "','" + this.tbSal.Text + "','" + this.tbAdd.Text + "','" + this.cmbRole.Text + "');";

            MySqlCommand command = new MySqlCommand(query, conn);

            string password = ArtichokeLogic.PasswordLogic.GeneratePassword();

            try
            {
                conn.Open();
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    MessageBox.Show("Error adding the employee");
                }
                else MessageBox.Show("New Employee added");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                try
                {
                    int loginID = 0;
                    string getIdQuery = $"SELECT ID FROM employee where FirstName = '{firstName}' AND LastName = '{lastName}' AND Salary = '{salary}'";
                    MySqlCommand getIdCommand = new MySqlCommand(getIdQuery, conn);
                    conn.Open();
                    var reader = getIdCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        loginID = reader.GetInt32(0);
                    }
                    conn.Close();


                    string insertLogin = $"INSERT INTO `login` (`empId`, `username`, `password`) VALUES ('{loginID}', '{firstName}1', '{password}')";

                    MySqlCommand command2 = new MySqlCommand(insertLogin, conn);

                    conn.Open();
                    int rows2 = command2.ExecuteNonQuery();
                    if (rows2 == 0)
                    {
                        MessageBox.Show("Creating login details failed.");
                    }
                    else MessageBox.Show("Successfully added login details for the employee");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                ClearBoxes();
            }
            string username = firstName + "1";
            MailManager.SendLoginDetails(username, password, empEmailBox.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.employee set ID='" + this.tbId.Text + "',FirstName='" + this.tbFn.Text + "',LastName='" + this.tbSn.Text + "',Age='" + this.tbAge.Text + "',Gender='" + this.cmbGender.Text + "',DepartmentName='" + this.cmDeptNames.Text + "',HireDate='" + this.dateTimePicker1.Text + "',Salary='" + this.tbSal.Text + "',Adress='" + this.tbAdd.Text + "',Role='" + this.cmbRole.Text + "' where ID='" + this.tbId.Text + "' ;";
            MySqlCommand command = new MySqlCommand(query, conn);


            try
            {
                conn.Open();
                int rows = command.ExecuteNonQuery();
                if (rows == 0 || rows == -1)
                {
                    MessageBox.Show("Error changing this employees details.");
                }
                else
                {
                    MessageBox.Show("Employee Details Updated successfully!");
                }


                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void btnSignoUT_Click(object sender, EventArgs e)
        {
            Login form3 = new Login();
            form3.Show();
            this.Hide();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.departments(DeptName)values('" + this.tbDeptName.Text + "');";
            MySqlCommand command = new MySqlCommand(query, conn);


            try
            {
                conn.Open();
                int rows = command.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("New Department added!");
                }
                else MessageBox.Show("Error adding the new department.");

                conn.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = $"update departments set DeptName='{this.tbDeptName.Text}' where DeptID='{tbDeptId.Text}' ;";
            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                int rows = command.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("Error changing the department details");
                }
                else
                {
                    MessageBox.Show("Department Details Updated successfully!");
                }
                conn.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "delete from dbi434661.departments where DeptID='" + this.tbDeptId.Text + "';";
            //string query2 = "delete from dbi434661.departments where DeptID='" + this.tbDid.Text + "';";
            //string query3 = "delete from dbi434661.login where eID='" + this.tbDid.Text + "';";
            MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlCommand command2 = new MySqlCommand(query2, conn);
            //MySqlCommand command3 = new MySqlCommand(query3, conn);

            try
            {
                conn.Open();


                // Object result = command.ExecuteScalar();
                //Object result2 = command2.ExecuteScalar();

                command.CommandType = CommandType.Text;
                command.ExecuteScalar();


                conn.Close();
                //command2.CommandType = CommandType.Text;
                //command2.ExecuteScalar();

                //command3.CommandType = CommandType.Text;
                //command3.ExecuteScalar();

                MessageBox.Show("Department Deleted");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form3 = new Login();
            form3.Show();
        }

        private void cmeIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "select * from dbi434661.employee where FirstName='" + cmeIds.Text + "';";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string ID = reader.GetInt32("ID").ToString();
                    string FirstName = reader.GetString("FirstName");
                    string LastName = reader.GetString("LastName");
                    string Age = reader.GetInt32("Age").ToString();
                    string Gender = reader.GetString("Gender");
                    string DepartmentName = reader.GetString("DepartmentName");
                    string HireDate = reader.GetDateTime("HireDate").ToString();
                    string Salary = reader.GetInt32("Salary").ToString();
                    string Adress = reader.GetString("Adress");
                    string Role = reader.GetString("Role");
                    this.tbId.Text = ID;
                    this.tbFn.Text = FirstName;
                    this.tbSn.Text = LastName;
                    this.tbAge.Text = Age;
                    this.cmbGender.Text = Gender;
                    this.cmDeptNames.Text = DepartmentName;
                    this.dateTimePicker1.Text = HireDate;
                    this.tbSal.Text = Salary;
                    this.tbAdd.Text = Adress;
                    this.cmbRole.Text = Role;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void cmDeptNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = $"select * from departments WHERE DeptName = '{cmDeptIds.SelectedItem}'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {

                    string dptmentId = reader.GetInt32("DeptID").ToString();
                    string dptName = reader.GetString("DeptName");
                    this.tbDeptId.Text = dptmentId;
                    this.tbDeptName.Text = dptName;

                }

                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void idCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "ID");
        }

        private void firstNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "FirstName");
        }

        private void lastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "LastName");
        }

        private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "Age");
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "Gender");
        }

        private void departmentNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "DepartmentName");
        }

        private void hireDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "HireDate");
        }

        private void endDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "EndDate");
        }

        private void salaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "Salary");
        }

        private void addressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "Adress");
        }

        private void roleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.FilterColumn(dShow, "Role");
        }

        private void ApplyStandardFilter()
        {
            this.idCheckBox.Checked = true;
            this.firstNameCheckBox.Checked = true;
            this.lastNameCheckBox.Checked = true;
            this.ageCheckBox.Checked = false;
            this.genderCheckBox.Checked = false;
            this.departmentNameCheckBox.Checked = true;
            this.hireDateCheckBox.Checked = true;     
            this.endDateCheckBox.Checked = false;
            this.salaryCheckBox.Checked = true;
            this.addressCheckBox.Checked = false;
            this.roleCheckBox.Checked = false;

        }

        private void empNextPageBtn_Click(object sender, EventArgs e)
        {
            empPageNumber++;
            pageNumberTextBox.Text = empPageNumber.ToString();
            this.ApplyStandardFilter();
            employeeManager.GetAllEmployees(dShow, empPageNumber);
        }

        private void empPrevPageBtn_Click(object sender, EventArgs e)
        {
            if (empPageNumber == 1) return;
            else empPageNumber--;
            pageNumberTextBox.Text = empPageNumber.ToString();
            this.ApplyStandardFilter();
            employeeManager.GetAllEmployees(dShow, empPageNumber);
        }

        List<CheckBox> checkBoxes = new List<CheckBox>();
        private void AddCheckBoxes()
        {
            checkBoxes.Add(idCheckBox);
            checkBoxes.Add(firstNameCheckBox);
            checkBoxes.Add(lastNameCheckBox);
            checkBoxes.Add(ageCheckBox);
            checkBoxes.Add(genderCheckBox);
            checkBoxes.Add(departmentNameCheckBox);
            checkBoxes.Add(hireDateCheckBox);
            checkBoxes.Add(endDateCheckBox);
            checkBoxes.Add(salaryCheckBox);
            checkBoxes.Add(addressCheckBox);
            checkBoxes.Add(roleCheckBox);
        }

        private void EnableAllCheckBoxes()
        {
            foreach (CheckBox box in checkBoxes)
            {
                box.Checked = true;
            }
        }

        private void enableAllBtn_Click(object sender, EventArgs e)
        {
            EnableAllCheckBoxes();
        }
        private void DisableAllCheckBoxes()
        {
            foreach (CheckBox box in checkBoxes)
            {
                box.Checked = false;
            }
        }
        private void disableAllBtn_Click(object sender, EventArgs e)
        {
            DisableAllCheckBoxes();
        }
    }
}