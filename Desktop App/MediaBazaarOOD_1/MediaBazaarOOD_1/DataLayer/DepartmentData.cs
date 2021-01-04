using MediaBazaarOOD_1.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.DataLayer
{
    public class DepartmentData
    {
        //About Departments
        public static void AddDepartment(Department department)
        {
            try
            {
                string dptName = department.DeptName;
                int id = department.DeptId;

                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
                string query = "insert into dbi434661.departments(`id`, `DepartmentName`)values(`id`, `dptName`)";
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot"); ;
            string sql = "SELECT * FROM Departments";
            List<Department> allDepartments = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dName = dr[2].ToString();
                    int id = Convert.ToInt32(dr[1]);
                    Department department = new Department(id, dName);
                    allDepartments.Add(department);

                }
                return allDepartments;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
                return new List<Department>();
            }
            finally
            {
                conn.Close();
            }

        }
        public static void EditDepartmentDetails()
        {

        }
        public static void DeleteDepartment()
        {

        }
        public static void GetDepartmentById()
        {

        }

    }
}
