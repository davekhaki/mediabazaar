using MySql.Data.MySqlClient;
using MediaBazaarOOD_1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.DataLayer
{
    public class Request
    {
        DbHelper dbHelper = new DbHelper();

        public void AddRequest(Requests request)
        {
            try
            {
                string productName = request.ProductName;
               
                //   int minimumQuantity = product.MinProductQuantity;


                string sql = "INSERT INTO request (Request, prodName) VALUES ('Restock' , @product"; 

                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@product", MySqlDbType.String).Value = productName;
               
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding requests details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }

        }
        public void CompleteRequest(int empID, string productName) {
            try
            {
                string sql = "update dbi434661.request set EmployeeID=@empid, RequestStatus='Done' where ProductName=@productname  ;";

                dbHelper.Conn.Open();

                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@empid", MySqlDbType.Int32).Value = empID;
                dbHelper.Cmd.Parameters.Add("@productname", MySqlDbType.Int32).Value = productName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refilling stock details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public void RefillStock(int pid, int pquantity) {
            try { 
            string sql = "update dbi434661.stock set Quantity=@quantity where ProductID=@productID  ;";

            dbHelper.Conn.Open();

            dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
            dbHelper.Cmd.Parameters.Add("@productID", MySqlDbType.Int32).Value = pid;
       ;
            dbHelper.Cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = pquantity;
            
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error refilling stock details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public List<Requests> LoadRequests() {

            List<Requests> newrequests = new List<Requests>();
            // try
            // {
            // MySqlConnection con = new MySqlConnection(Config.conString);

            string sql = "SELECT * FROM dbi434661.request ";
            // con.Open();

            dbHelper.Conn.Open();
            dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
            var dr = dbHelper.Cmd.ExecuteReader();

            while (dr.Read())
            {
                Requests request = new Requests();
                request.RequestID = Convert.ToInt32(dr[0]);
          
                request.ProductName = dr[1].ToString();
                request.Status = dr[2].ToString();
                request.EmpId = Convert.ToInt32(dr[3]);

                //product.MinProductQuantity = Convert.ToInt32(dr[5]);
                newrequests.Add(request);
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
            return newrequests;
        }


        //    try
        //    {
        //        string productName = request.Request;
        //        int value = request.RestockValue;

        //        MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
        //        string query = "insert into dbi434661.request(`Request`, `ProdName`)values(`productName`, `value`)";
        //        MySqlCommand command = new MySqlCommand(query, conn);
        //        conn.Open();
        //        command.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.ToString());
        //    }
    }
    //public static List<Request> GetAllRequests()
    //{
    //MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
    //string sql = "SELECT * FROM Request";
    //List<Request> allRequests = null;

    //try
    //{
    //    MySqlCommand cmd = new MySqlCommand(sql, conn);
    //    conn.Open();
    //    MySqlDataReader dr = cmd.ExecuteReader();
    //    while (dr.Read())
    //    {
    //        string productName = dr[2].ToString();
    //        int value = Convert.ToInt32(dr[1]);
    //        Request request = new Request(productName, value);
    //        allRequests.Add(request);

    //    }
    //    return allRequests;
    //}
    //catch (Exception ex)
    //{
    //    throw new Exception(ex.ToString());
    //    return new List<Request>();
    //}
    //finally
    //{
    //    conn.Close();
    //}





}

