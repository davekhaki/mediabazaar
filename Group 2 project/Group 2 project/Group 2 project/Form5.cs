using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Group_2_project
{
    public partial class Form5 : Form
    {
        private string constring;
        public Form5()
        {
            InitializeComponent();
            GetEmp();
            ConnectDatabase();

            empListForSchedule.DefaultCellStyle.ForeColor = Color.Black;
            scheduleGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewStock.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMin.DefaultCellStyle.ForeColor = Color.Black;
        }
        void ConnectDatabase()
        {
            constring = "Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot";

        }
       

        private void loadStockBtn_Click(object sender, EventArgs e)
        {
            LoadStock();
            MinQuantity();

        }

        public void MinQuantity() {

            
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from stock where Quantity < MinimumQuantity;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                dataGridViewMin.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void /*private List<TempStock> */ LoadStock()
        {
            
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
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "update dbi434661.stock set ProductID=" + this.tbId.Text + ",ProductName='" + this.tbPname.Text + "',ProductPrice='" + this.tbPprice.Text + "',Brand='" + this.tbBrand.Text + "',Quantity=" + this.tbQuantity.Text + " ,MinimumQuantity '"+ this.tbMinQ.Text+"' where ProductID=" + this.tbId.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Product Details Updated successfully!");
                MinQuantity();
                LoadStock();

                /*   while (reader.Read())
                   {

                   }*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 =new  Form3();
            form3.Show();
            this.Hide();
        }


        private void btnRequest_Click(object sender, EventArgs e)
        {
            //Comments by Mary
            //I suggest if you click this request button  it should take you to another form
            //The form should have a way to show all stocks that are below minimum quantity and there fore
            //From that the mnager shud be able to do all requests
            //Manager shud be able to all all functionalities related to low stocks
            /*
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            */
            string restock= "Restock";
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "insert dbi434661.request (Request)values('"+restock+"') ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Request Sent successfully!");
                LoadStock();

                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0){

                DataGridViewRow row =dataGridViewStock.Rows[e.RowIndex];
                tbId.Text = row.Cells["ProductID"].Value.ToString();
                tbPname.Text = row.Cells["ProductName"].Value.ToString();
                tbPprice.Text = row.Cells["ProductPrice"].Value.ToString();
                tbBrand.Text = row.Cells["Brand"].Value.ToString();
                tbQuantity.Text = row.Cells["Quantity"].Value.ToString();
                tbMinQ.Text = row.Cells["MinimumQuantity"].Value.ToString();
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "insert into dbi434661.stock(ProductName,ProductPrice,Brand,Quantity,MinimumQuantity)values('" + this.tbPname.Text + "','" + this.tbPprice.Text + "','" + this.tbBrand.Text + "','" + this.tbQuantity.Text + "','"+this.tbMinQ.Text+"');";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("New Product added");
                LoadStock();

                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void empListForSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.empListForSchedule.Rows[e.RowIndex];

                SelectedEmpTxt.Text = row.Cells["ID"].Value.ToString();
            }
        }

        public string TimeOfDayInput;

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

        private void button4_Click(object sender, EventArgs e) //add shift btn
        {
            TimeOfDayInput = GetTimeOfDay();



            MySqlConnection conn = new MySqlConnection(constring);
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

        private void GetEmp()
        {
            MySqlConnection conn = new MySqlConnection(constring);
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

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(constring);
            MySqlCommand query = new MySqlCommand($"SELECT e.FirstName, e.LastName, s.EmployeeID, s.TimeOfDay, s.Day FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID WHERE e.FirstName = '{firstnametxt.Text}' AND LastName = '{lastnametxt.Text}'", conn);
            //MySqlCommand query = new MySqlCommand($"SELECT * FROM schedule WHERE FirstName = '{firstnametxt.Text}' AND LastName = '{lastnametxt.Text}'", conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = query;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbaTableset;
                scheduleGridView.DataSource = bSource;
                sda.Update(dbaTableset);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "delete from dbi434661.stock where ProductID=" + this.tbId.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                LoadStock();
                MessageBox.Show("Deleted successfully!");
                conn.Close();

                /*   while (reader.Read())
                   {

                   }*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void scheduleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
