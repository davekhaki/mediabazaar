using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ArtichokeData
{
    public class StockManager
    {
        /*------------- all the stock related data access -------------*/

        public void LoadStock(DataGridView dataGrid, NumericUpDown numeric)
        {
            int offset;
            int pageNumber = Convert.ToInt32(numeric.Value);
            if(pageNumber == 1)
            {
                offset = 0;
            }
            else
            {
                offset = (pageNumber - 1) * 10;
            }
            
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = $"SELECT * FROM stock LIMIT 10 OFFSET {offset}";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@offset", MySqlDbType.String).Value = offset;

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //method to show stock that is out
        public void LoadOutofStock(DataGridView dataGrid)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "select * from stock where Quantity < MinimumQuantity;";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //method for changing stock details
        public void EditStock(int productId, string productName, int productPrice, string productBrand, int Quantity, int Minimum)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "update stock set ProductID=@ID, ProductName=@Name, ProductPrice=@Price, Brand=@Brand, Quantity=@Quantity, MinimumQuantity=@Min where ProductID=@ID";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = productId;
                cmd.Parameters.Add("@Name", MySqlDbType.String).Value = productName;
                cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = productPrice;
                cmd.Parameters.Add("@Brand", MySqlDbType.String).Value = productBrand;
                cmd.Parameters.Add("@Quantity", MySqlDbType.Int32).Value = Quantity;
                cmd.Parameters.Add("@Min", MySqlDbType.Int32).Value = Minimum;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Details Updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //deleting stock
        public void DeleteStock(int prodId)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "delete from dbi434661.stock where ProductID=@ID";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = prodId;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            
        }
    }
}
