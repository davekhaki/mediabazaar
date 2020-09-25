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

        private List<TempStock> LoadStock()
        {
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
        }
    }
}
