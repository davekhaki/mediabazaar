using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarOOD_1;
using MediaBazaarOOD_1.LogicLayer;
using MediaBazaarOOD_1.DataLayer;
using MediaBazaarOOD_1.Class;

namespace MediaBazaarOOD_1.Forms
{
    public partial class Manager : Form
    {
        StockManager stockmanager = new StockManager();
        Product prod;
        StockData stockdata = new StockData();
        public Manager()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbId.Text = row.Cells["ProductID"].Value.ToString();
                tbProductName.Text = row.Cells["ProductName"].Value.ToString();
                tbPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                tbBrand.Text = row.Cells["Brand"].Value.ToString();
                tbQuantuity.Text = row.Cells["ProductQuantity"].Value.ToString();
               // tbMinimumQuantity.Text = row.Cells["MinimumQauntity"].Value.ToString();
                string requestStocking = row.Cells["ProductQuantity"].Value.ToString(); ;
               // restock = row.Cells["Quantity"].Value.ToString();
                //tbMinimumQuantity.Text = row.Cells["MinimumQuantity"].Value.ToString();
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            
            // List<Product> prod = new List<Product>();
            // prod.Add(new Product("ron", 1, "ron", 12, 11));
                 dataGridView1.DataSource = stockmanager.AllStock();
            // dataGridView1.DataSource = prod;
            //StockData da = new StockData();

           // dataGridView1.DataSource = da.GetAllStock();

           // stockmanager.LoadStock(dataGridView1);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //stockdata.AddProduct(new Product("Terminator", 12, "Terminator", 13));
            stockmanager.AddProduct(new Product(tbProductName.Text, Convert.ToInt32(tbPrice.Text),tbBrand.Text,Convert.ToInt32(tbQuantuity.Text)));
           // Convert.ToInt32(tbMinimumQuantity.Text)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stockmanager.DeleteProduct((Convert.ToInt32(tbId.Text)));
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            stockmanager.EditStock(Convert.ToInt32(tbId.Text),tbProductName.Text, Convert.ToInt32(tbPrice.Text), tbBrand.Text, Convert.ToInt32(tbQuantuity.Text));
        }
    }
}
