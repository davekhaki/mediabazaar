using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GetEmp();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void employeeLoadBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT * FROM employee", conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = query;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                empDataGrid.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            /*
            conn.Open();

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                TempEmployee employee = new TempEmployee()
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Age = reader.GetInt32(3),
                    Gender = reader.GetString(4),
                    DepartmentId = reader.GetInt32(5),
                    HireDate = reader.GetString(6),
                    Salary = reader.GetInt32(7),
                    Adress = reader.GetString(8),
                    Role = reader.GetString(9)
                };

                employeeBox.Items.Add(employee);
            }
            conn.Close();

        */
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT * FROM schedule WHERE EmployeeID = '{EmpIdTextBox.Text}'", conn);

            conn.Open();

            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                Shift shift = new Shift()
                {
                    TimeOfDay = reader.GetString(1),
                    Day = reader.GetDateTime(2),
                };

                ShiftListBox.Items.Add(shift.ToString());
            }

            }

        private void ShiftListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddShiftCalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public string TimeOfDayInput;

        private void button4_Click_1(object sender, EventArgs e)
        {
            TimeOfDayInput = GetTimeOfDay();

            

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"INSERT INTO `schedule` (`EmployeeID`, `TimeOfDay`, `Day`) VALUES ('{SelectedEmpTxt.Text}', '{TimeOfDayInput}', '{dateTimeShiftPicker.Text}')", conn);

            conn.Open();

            int affectedRows = query.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                MessageBox.Show("Error adding the shift");
            }
            else MessageBox.Show("Shift added successfully!"); 

            conn.Close();

        }

        private string GetTimeOfDay()
        {
            if (morningBtn.Checked == true)
            {       
                return "Morning";
            }
            else if (AfternoonBtn.Checked == true)
            {
                return "Afternoon";
            }
            else
            {
                return "Evening";
            }
        }

        private void testBTN_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void empDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void empListForSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.empListForSchedule.Rows[e.RowIndex];

                SelectedEmpTxt.Text = row.Cells["ID"].Value.ToString();
            }
        }

        private void GetEmp()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT `ID`,`FirstName`,`LastName` FROM employee", conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = query;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                empListForSchedule.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SelectedEmpTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeShiftPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AfternoonBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EveningBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
