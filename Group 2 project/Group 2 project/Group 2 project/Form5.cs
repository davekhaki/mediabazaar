﻿using MySql.Data.MySqlClient;
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

        private void Addbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string query = "insert into dbi434661.stock(ProductID,ProductName,ProductPrice,Brand,Quantity)values('" + this.tbId + "','" + this.tbPname.Text + "'," + this.tbPprice.Text + ",'" + this.tbBrand.Text + "','" + this.tbQuantity.Text+ "');";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("New Product added");

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
