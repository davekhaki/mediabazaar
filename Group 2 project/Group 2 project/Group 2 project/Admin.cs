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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.employee(ID,Firstname,LastName,Age,Gender,DepartmentID,HireDate,Salary,Adress,Role)values('"+this.tbId.Text+"','"+this.tbFn.Text+"','"+this.tbSn.Text+"','"+this.tbAge.Text+"','"+this.tbGen.Text+"','"+this.tbDid.Text+"','"+this.tbHdate.Text+"','"+this.tbSal.Text+"','"+this.tbAdd.Text+"','"+this.tbRole.Text+"');";
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

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.employee set ID='" + this.tbId.Text + "',FirstName='" + this.tbFn.Text + "',LastName='" + this.tbSn.Text + "',Age='" + this.tbAge.Text + "',Gender='" + this.tbGen.Text + "',DepartmentId='" + this.tbDid.Text + "',HireDate='" + this.tbHdate.Text + "',Salary='" + this.tbSal.Text + "',Adress='" + this.tbAdd.Text + "',Role='" + this.tbRole.Text + "' where ID='" + this.tbId.Text + "' ;";
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

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "delete from dbi434661.employee where ID='" + this.tbId.Text + "';";
            string query2= "delete from dbi434661.employee where DepartmentID='" +this.tbDid.Text + "';";

            conn.Open();
            //MySqlCommand cm= new MySqlCommand(query, conn);
            ////MySqlCommand cm = new MySqlCommand(query2, conn);
            //cm.CommandType = CommandType.Text;
            //obj=cm.ExecuteScalar();
            
            
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlCommand command2 = new MySqlCommand(query2, conn);
            

          // Object result = command.ExecuteScalar();
            //Object result2 = command2.ExecuteScalar();

            command.CommandType = CommandType.Text;
            command.ExecuteScalar();
            
           

            command2.CommandType = CommandType.Text;
            command2.ExecuteScalar();

            MessageBox.Show("Deleted");

            //MySqlDataReader reader;

            //try
            //{
            //    conn.Open();
            //    reader = command.ExecuteReader();
            //    MessageBox.Show("Employee data deleted");

            //    while (reader.Read())
            //    {

            //    }


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}








        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from employee;", conDataBase);

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
    }
}
