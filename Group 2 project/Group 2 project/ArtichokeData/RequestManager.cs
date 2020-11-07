using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArtichokeData
{
    public class RequestManager
    {


        public void SendRequest(string productName)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "INSERT INTO request (Request, prodName) VALUES ('Restock' , @product";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("product", MySqlDbType.String).Value =productName;

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Request sent!");
            }
        }
    }
}
