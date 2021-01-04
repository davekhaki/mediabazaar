using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MediaBazaarOOD_1.LogicLayer
{
    public class StockManager
    {
        List<Product> products;
        StockData stockdata = new StockData();

        public bool AddProduct(Product product)
        {
            bool exist = false;
           /* try

            {
                foreach (Product p in products)
                {
                    if (products.Contains(p))
                    {
                        throw new ArgumentException("Product already exists");
                    }
                    else
                 //   {
           */
                        stockdata.AddProduct(product);
                        //products.Add(product);
                        return exist = true;
        /*         
        }
               }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);...FOR FRONT END
                throw new Exception(ex.ToString());
            }
            return exist;
        */
        }
        public bool DeleteProduct(int id)
        {
            bool exist = false;
                /*

            try

            {//loop throu to check if product exists before deleteing
                
                foreach (Product p in products)
                {
                    if (!products.Contains(p))
                    {
                        throw new ArgumentException("Product doesnt exists");
                    }
                    else
                    {
                */
                        stockdata.DeleteProduct(id);
                return exist=true;
                //products.Add(p);
                //exist = true;
                /*
            }
        }
    }
    catch (Exception ex)
    {
        //MessageBox.Show(ex.Message);...FOR FRONT END
        throw new Exception(ex.ToString());
    }
    return exist;
                
                */

}

        public List<Product> AllStock()
        {
           return stockdata.GetAllStock();
        }

        public void LoadStock(DataGridView dataGrid)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = $"SELECT * FROM stock ";

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

        //method to show stock that is out
        public void LoadOutofStock()
        {
          
        }

        
        public bool EditStock(int id, string pName, int pPrice, string pBrand, int pQuantity)
        {
            stockdata.EditProductDetails( id,  pName,  pPrice,  pBrand, pQuantity);
            return true;
        }

           
        }

       
      

       
    }

