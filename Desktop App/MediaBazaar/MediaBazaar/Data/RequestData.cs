using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarOO;
using MediaBazaarOO.Entities;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Data
{
    public class RequestData
    {
        public static void CompleteRequest(int requestId)
        {
            var conn = new MySqlConnection(Config.ConString);
            try
            {
                string sql = "UPDATE request SET RequestStatus = 'Done' WHERE request.RequestID = @id";
                
                conn.Open();
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("id", MySqlDbType.String).Value = requestId;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        public static List<Request> GetAllRequests()
        {
            List<Request> newrequests = new List<Request>();

            string sql = "SELECT * FROM request ";

            var conn = new MySqlConnection(Config.ConString);
            conn.Open();
            var cmd = new MySqlCommand(sql, conn);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Request request = new Request(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                newrequests.Add(request);
            }


            conn.Close();

            return newrequests;
        }

        public static void AddRequest(string productName)
        {
            var conn = new MySqlConnection(Config.ConString);
            try
            {
                string sql = "INSERT INTO request (RequestID, Request, RequestStatus, prodName, EmployeeID, DepartmentID) VALUES (NULL, 'Restock', NULL, @prodName, NULL, NULL)";

                conn.Open();
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("prodName", MySqlDbType.String).Value = productName;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}