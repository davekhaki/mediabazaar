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
    }
}
