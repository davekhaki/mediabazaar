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
    public partial class Manager : Form
    {
        ArtichokeData.StockManager stockManager = new ArtichokeData.StockManager();
        ArtichokeData.employee.ScheduleManager scheduleManager = new ArtichokeData.employee.ScheduleManager();
        ArtichokeData.EmployeeManager employeeManager = new ArtichokeData.EmployeeManager();
        ArtichokeData.RequestManager requestManager = new ArtichokeData.RequestManager();

        public Manager()
        {
            InitializeComponent();
           
            stockManager.LoadStock(dataGridViewStock, stockNumeric);
            stockManager.LoadOutofStock(dataGridViewMin);

            employeeManager.GetAllEmployees(empListForSchedule);

            empListForSchedule.DefaultCellStyle.ForeColor = Color.Black;
            scheduleGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewStock.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMin.DefaultCellStyle.ForeColor = Color.Black;
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            stockManager.EditStock(Convert.ToInt32(tbStockId.Text), tbProdName.Text, Convert.ToInt32(tbProdPrice.Text), tbProdBrand.Text, Convert.ToInt32(tbProdQuantity.Text), Convert.ToInt32(tbMinQuantity.Text));
            stockManager.LoadStock(dataGridViewStock, stockNumeric);
            stockManager.LoadOutofStock(dataGridViewMin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form3 =new  Login();
            form3.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbProdName.Text))
            {
                MessageBox.Show("Please enter the product name.");
                return;
            }
            requestManager.SendRequest(tbProdName.Text);
            stockManager.LoadStock(dataGridViewStock, stockNumeric);
        }




        string restock;

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0){

                DataGridViewRow row =dataGridViewStock.Rows[e.RowIndex];
                tbStockId.Text = row.Cells["ProductID"].Value.ToString();
                tbProdName.Text = row.Cells["ProductName"].Value.ToString();
                tbProdPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                tbProdBrand.Text = row.Cells["Brand"].Value.ToString();
                tbProdQuantity.Text = row.Cells["Quantity"].Value.ToString();
                restock= row.Cells["Quantity"].Value.ToString();
                tbMinQuantity.Text = row.Cells["MinimumQuantity"].Value.ToString();
            }
        }
        private void dataGridViewMin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewMin.Rows[e.RowIndex];
                tbStockId.Text = row.Cells["ProductID"].Value.ToString();
                
                restock = row.Cells["MinimumQuantity"].Value.ToString();
                tbMinQuantity.Text = row.Cells["MinimumQuantity"].Value.ToString();


            }
        }
        private void loadStockBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.stock set MinimumQuantity='" + restock + "' where ProductID='" + this.tbStockId.Text + "' ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Product Details Updated successfully!");
                stockManager.LoadOutofStock(dataGridViewMin);
                stockManager.LoadStock(dataGridViewStock, stockNumeric);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                
                conn.Close(); }
           

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.stock(ProductName,ProductPrice,Brand,Quantity,MinimumQuantity)values('" + this.tbProdName.Text + "','" + this.tbProdPrice.Text + "','" + this.tbProdBrand.Text + "','" + this.tbProdQuantity.Text + "','"+this.tbProdQuantity.Text+"');";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("New Product added");
                stockManager.LoadStock(dataGridViewStock, stockNumeric);

                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void empListForSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.empListForSchedule.Rows[e.RowIndex];

                //SelectedEmpTxt.Text = row.Cells["ID"].Value.ToString();
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
            scheduleManager.AddSchedule(addShiftFirstNameText.Text, addShiftSurnameText.Text, GetTimeOfDay(), dateTimeShiftPicker);
        }

        private void button3_Click(object sender, EventArgs e) // get schedules based on first and last name button
        {
            scheduleManager.GetScheduleByName(scheduleGridView, firstnametxt.Text, lastnametxt.Text);
        }

        private void Deletebtn_Click(object sender, EventArgs e) //stock delete button
        {
            stockManager.DeleteStock(Convert.ToInt32(tbStockId.Text));
            //reload the stock after deleting
            stockManager.LoadStock(dataGridViewStock, stockNumeric);
            stockManager.LoadOutofStock(dataGridViewMin);
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
        }

        private void scheduleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
