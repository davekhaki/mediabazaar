using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Entities;
using MediaBazaarOO;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Data
{
    public class StockData
    {
        private readonly DbHelper dbHelper = new DbHelper();

        public void AddProduct(Product product)
        {
            try
            {
                string productName = product.ProductName;
                int price = product.ProductPrice;
                string brand = product.Brand;
                int quantity = product.ProductQuantity;
                //   int minimumQuantity = product.MinProductQuantity;


                string sql = "INSERT INTO dbi434661.stock(ProductName, ProductPrice,Brand,Quantity)values(@name, @price, @brand, @quantity)";

                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@name", MySqlDbType.String).Value = productName;
                dbHelper.Cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
                dbHelper.Cmd.Parameters.Add("@brand", MySqlDbType.String).Value = brand;
                dbHelper.Cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
                //  dbHelper.Cmd.Parameters.Add("@minimumQuantity", MySqlDbType.Int32).Value = minimumQuantity;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing department details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }

        }

        public List<Product> GetAllStock()
        {
            List<Product> newProducts = new List<Product>();
            try
            {
                MySqlConnection con = new MySqlConnection(Config.ConString);

                string sql = "SELECT * FROM stock ";

                con.Open();
                var cmd = new MySqlCommand(sql, con);
                var dr = cmd.ExecuteReader();

                //dbHelper.Conn.Open();
                //dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                //var dr = dbHelper.Cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(dr[0]);
                    product.ProductName = dr[1].ToString();
                    product.ProductPrice = Convert.ToInt32(dr[2]);
                    product.Brand = dr[3].ToString();
                    product.ProductQuantity = Convert.ToInt32(dr[4]);
                    //product.MinProductQuantity = Convert.ToInt32(dr[5]);
                    newProducts.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting stock details details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }

            return newProducts;
        }

        public void EditProductDetails(int id, string pName, int pPrice, string pBrand, int pQuantity)
        {
            try
            {
                //int Id = product.ProductId;
                //string productName = product.ProductName;
                // int price = product.ProductPrice;
                // string brand = product.Brand;
                // int quantity = product.ProductQuantity;
                //int minimumQuantity = product.MinProductQuantity;

                string sql = "UPDATE dbi434661.stock SET ProductName = @name, ProductPrice=@price,Brand=@brand,Quantity=@quantity WHERE ProductID = @id";

                dbHelper.Conn.Open();

                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                dbHelper.Cmd.Parameters.Add("@name", MySqlDbType.String).Value = pName;
                dbHelper.Cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = pPrice;
                dbHelper.Cmd.Parameters.Add("@brand", MySqlDbType.String).Value = pBrand;
                dbHelper.Cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = pQuantity;
                //dbHelper.Cmd.Parameters.Add("@minimumQuantity", MySqlDbType.Int32).Value = minimumQuantity;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing department details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }

        }
        public void DeleteProduct(int Id)
        {
            // int Id = product.ProductId;
            try
            {

                string sql = "delete from dbi434661.stock where ProductID=@id";

                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting stock details details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public void UpdateProduct(int id, int quantity)
        {
            var sql = "UPDATE stock SET Quantity = @quantity WHERE stock.ProductID = @id";

            try
            {
                dbHelper.Conn = new MySqlConnection(Config.ConString);
                dbHelper.Conn.Open();

                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                dbHelper.Cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;

                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }
    }
}
