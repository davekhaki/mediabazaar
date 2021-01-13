using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaar.Entities;
using MediaBazaarOO;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Data
{
    public class DepartmentData
    {
        public static DbHelper dbHelper = new DbHelper();
        //About Departments
        public static void AddDepartment(Department department)
        {
            var sql = "INSERT INTO departments(`DeptID`, `DeptName`) VALUES (NULL, @name)";
            try
            {
                var conn = new MySqlConnection(Config.ConString);
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", department.DeptName);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = new MySqlConnection(Config.ConString); ;
            string sql = "SELECT * FROM Departments";
            List<Department> allDepartments = new List<Department>();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dName = dr[1].ToString();
                    int id = Convert.ToInt32(dr[0]);
                    Department department = new Department(id, dName);
                    allDepartments.Add(department);

                }
                return allDepartments;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public static void EditDepartmentDetails(Department department)
        {
            string sql = "UPDATE departments SET DeptName = @name WHERE departments.DeptID = @id";
            try
            {
                dbHelper.Conn = new MySqlConnection(Config.ConString);
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Conn.Open();
                dbHelper.Cmd.Parameters.AddWithValue("@name", department.DeptName);
                dbHelper.Cmd.Parameters.AddWithValue("@id", department.DeptId);
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                dbHelper.Conn.Close();
            }

        }
    }
}
