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
        public Administration()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.employee(ID,Firstname,LastName,Age,Gender,DepartmentID,HireDate,Salary,Adress,Role)values('" + this.tbId.Text + "','" + this.tbFn.Text + "','" + this.tbSn.Text + "','" + this.tbAge.Text + "','" + this.tbGen.Text + "','" + this.tbDid.Text + "','" + this.dateTimePicker1.Text + "','" + this.tbSal.Text + "','" + this.tbAdd.Text + "','" + this.tbRole.Text + "');";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("New Employee added");

                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.employee set ID='" + this.tbId.Text + "',FirstName='" + this.tbFn.Text + "',LastName='" + this.tbSn.Text + "',Age='" + this.tbAge.Text + "',Gender='" + this.tbGen.Text + "',DepartmentId='" + this.tbDid.Text + "',HireDate='" + this.dateTimePicker1.Text + "',Salary='" + this.tbSal.Text + "',Adress='" + this.tbAdd.Text + "',Role='" + this.tbRole.Text + "' where ID='" + this.tbId.Text + "' ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Employee Details Updated successfully!");

                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "delete from dbi434661.employee where ID='" + this.tbId.Text + "';";
            string query2 = "delete from dbi434661.departments where DeptID='" + this.tbDid.Text + "';";
            string query3 = "delete from dbi434661.login where eID='" + this.tbDid.Text + "';";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlCommand command2 = new MySqlCommand(query2, conn);
            MySqlCommand command3 = new MySqlCommand(query3, conn);

            try
            {
                conn.Open();


                // Object result = command.ExecuteScalar();
                //Object result2 = command2.ExecuteScalar();

                command.CommandType = CommandType.Text;
                command.ExecuteScalar();



                command2.CommandType = CommandType.Text;
                command2.ExecuteScalar();

                command3.CommandType = CommandType.Text;
                command3.ExecuteScalar();

                MessageBox.Show("Deleted");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnSignoutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from dbi434661.employee;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;

                dShow.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSignoUT_Click(object sender, EventArgs e)
        {
            Administration ad = new Administration();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand("select * from dbi434661.departments;", conDataBase);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbaTableset = new DataTable();
                    sda.Fill(dbaTableset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbaTableset;

                    this.dgDepartments.DataSource = bSource;
                    sda.Update(dbaTableset);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.departments(DeptID,DeptName)values('" + this.tbDeptId.Text + "','" + this.tbDeptName.Text + "');";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("New Department added");

                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.departments set DeptName='" + this.tbDeptName.Text + "' where DeptID='" + this.tbDeptId + "' ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Department Details Updated successfully!");

                while (reader.Read())
                {

                }


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
    }
}
