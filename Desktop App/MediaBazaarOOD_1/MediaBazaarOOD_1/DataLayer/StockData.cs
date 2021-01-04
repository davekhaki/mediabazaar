using MediaBazaarOOD_1.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaBazaarOOD_1.DataLayer
{
    public class StockData
    {
        //About Products
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
            // try
            // {
          // MySqlConnection con = new MySqlConnection(Config.conString);

                string sql = "SELECT * FROM dbi434661.stock ";
           // con.Open();
               
               dbHelper.Conn.Open();
                 dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                var dr = dbHelper.Cmd.ExecuteReader();

                while (dr.Read()) {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(dr[0]);
                    product.ProductName = dr[1].ToString();
                    product.ProductPrice = Convert.ToInt32(dr[2]);
                    product.Brand = dr[3].ToString();
                    product.ProductQuantity = Convert.ToInt32(dr[4]);
                //product.MinProductQuantity = Convert.ToInt32(dr[5]);
                newProducts.Add(product);
                }

               // return newProducts;

           // }
     

         //   catch (Exception ex)
           /// {
              //  MessageBox.Show("Error getting stock details details:" + ex);
            //}
            //finally
            //{


                dbHelper.Conn.Close();

            //}
            return newProducts;

        }
        /*  try
          {
              MySqlCommand cmd = new MySqlCommand(sql, conn);
              conn.Open();
              MySqlDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {
                  string productName = dr[1].ToString();
                  int productPrice = Convert.ToInt32(dr[2]);
                  string productBrand = dr[3].ToString();
                  int productQuantity = Convert.ToInt32(dr[4]);
                  int productMinimumQuantity = Convert.ToInt32(dr[5]);

                  Product p = new Product(productName, productPrice, productBrand, productQuantity, productMinimumQuantity);
                  newProducts.Add(p);
              }
              return newProducts;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.ToString());
              //return new List<Product>();
          }
          finally
          {
              conn.Close();
          }*/

 

        public void EditProductDetails(int id, string pName, int pPrice, string pBrand, int pQuantity)
        {
            try { 
                /*
            int Id = product.ProductId;
            string productName = product.ProductName;
            int price = product.ProductPrice;
            string brand = product.Brand;
            int quantity = product.ProductQuantity;
           // int minimumQuantity = product.MinProductQuantity;
                */
            string sql = "UPDATE dbi434661.stock SET ProductName = @name, ProductPrice=@price,Brand=@brand,Quantity=@quantity WHERE ProductID = @id";

            dbHelper.Conn.Open();

            dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
            dbHelper.Cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            dbHelper.Cmd.Parameters.Add("@name", MySqlDbType.String).Value = pName;
            dbHelper.Cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = pPrice;
            dbHelper.Cmd.Parameters.Add("@brand", MySqlDbType.String).Value = pBrand;
            dbHelper.Cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = pQuantity;
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
        public void GetStockCount()
        {
            try
            {

                string sql = "SELECT * FROM dbi434661.stock WHERE MinimumQuantity > Quantity; ";

                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting stock details details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }


        }



        static int id;
        public int getId(string name, int price, string brand)
        {

            try
            {

                string Name = name;
                int Price = price;
                string Brand = brand;



                string sql = "SELECT ProductID FROM dbi434661.stock WHERE ProductName=@name AND ProductPrice=@price AND ProductBrand=@brand";

                dbHelper.Conn.Open();

                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);


                dbHelper.Cmd.Parameters.Add("@name", MySqlDbType.String).Value = Name;
                dbHelper.Cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = Price;
                dbHelper.Cmd.Parameters.Add("@brand", MySqlDbType.String).Value = Brand;
                var reader = dbHelper.Cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(1);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing department details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();

            }
            return id;
        }
    }
}
