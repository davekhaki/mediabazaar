using MySql.Data.MySqlClient;
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
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadStockBtn_Click(object sender, EventArgs e)
        {
            LoadStock();

        }

        public void /*private List<TempStock> */ LoadStock()
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
            /*
            List<TempStock> stocks = new List<TempStock>();

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT * FROM stock", conn);

            conn.Open();

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                TempStock item = new TempStock
                {
                    id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    price = reader.GetInt32(2),
                    brand = reader.GetString(3),
                    quantity = reader.GetInt32(4)
                };

                stocks.Add(item);
                stockBox.Items.Add(item);
            }
            conn.Close();

            return stocks;
            */

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.stock(ProductID,ProductName,ProductPrice,Brand,Quantity)values("+ this.tbId.Text + ",'" + this.tbPname.Text + "','" + this.tbPprice.Text+ "'," + this.tbBrand.Text + ",'" + this.tbQuantity.Text + "');";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "update dbi434661.stock set ProductID=" + this.tbId.Text + ",ProductName='" + this.tbPname.Text + "',ProductPrice='" + this.tbPprice.Text + "',Brand='" + this.tbBrand.Text + "',Quantity=" + this.tbQuantity.Text + " where ProductID=" + this.tbId.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Product Details Updated successfully!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Comments by Mary
            //I suggest if you click this request button  it should take you to another form
            //The form should have a way to show all stocks that are below minimum quantity and there fore
            //From that the mnager shud be able to do all requests
            //Manager shud be able to all all functionalities related to low stocks

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "delete from dbi434661.stock where ProductID=" + this.tbId.Text + " ;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
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

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){

                DataGridViewRow row =dataGridViewStock.Rows[e.RowIndex];
                tbId.Text = row.Cells["ProductID"].Value.ToString();
                tbPname.Text = row.Cells["ProductName"].Value.ToString();
                tbPprice.Text = row.Cells["ProductPrice"].Value.ToString();
                tbBrand.Text = row.Cells["Brand"].Value.ToString();
                tbQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }
    }
}
