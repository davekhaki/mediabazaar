﻿using System;
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
    public partial class Employeeselfservice : Form
    {
        public Employeeselfservice(string username)
        {
            InitializeComponent();
            this.Text = username;
          
            LoadRequest();
            LoadStock();
           GetSchedule(username);
            dataGridViewSchedule.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewStock.DefaultCellStyle.ForeColor = Color.Black;
           
        }

        public void GetSchedule(string username) {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT e.FirstName, e.LastName, s.EmployeeID, s.TimeOfDay, s.Day FROM ((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l ON l.empId = e.ID) WHERE l.username = '{username}' ;", conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = query;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                dataGridViewSchedule.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void LoadStock()
        {
            string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from stock;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                dataGridViewStock.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

string Done;
        public void LoadRequest() {
            string constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select RequestID, Request, RequestStatus, prodName from request;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ForeColor = System.Drawing.Color.Black;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Done= row.Cells["RequestID"].Value.ToString();
               
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            string DoneTask = "Done";
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.request set RequestStatus='"+DoneTask+"' where RequestID="+Done+" ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Task Done!");
                LoadRequest();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewStock.ForeColor = System.Drawing.Color.Black;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewStock.Rows[e.RowIndex];
               
                tbID.Text = row.Cells["ProductID"].Value.ToString();
                tbQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.stock set ProductID=" + this.tbID.Text + ",Quantity=" + this.tbQuantity.Text + " where ProductID=" + this.tbID.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Product Details Updated successfully!");
                

                /*   while (reader.Read())
                   {

                   }*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSchedule.ForeColor = System.Drawing.Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form3 = new Login();
            form3.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            string DoneTask = "Done";
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.request set RequestStatus='" + DoneTask + "' where RequestID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Task Done!");
                LoadRequest();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.stock set ProductID=" + this.tbID.Text + ",Quantity=" + this.tbQuantity.Text + " where ProductID=" + this.tbID.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Product Details Updated successfully!");


                /*   while (reader.Read())
                   {

                   }*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
