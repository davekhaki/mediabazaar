using MediaBazaarOOD_1.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarOOD_1.DataLayer
{
    public class DepartmentData
    {//About Departments
        public static void AddDepartment(Department department)
        {
            try
            {
                string dptName = department.DeptName;

                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
                string query = "insert into dbi434661.departments(`DeptName`)values(@DeptName)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DeptName", department.DeptName);
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
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string sql = "SELECT * FROM departments";
            List<Department> allDepartments = new List<Department>();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Department department;
                    int id = Convert.ToInt32(dr[0]);
                    string dName = dr[1].ToString();
                    department = new Department(id, dName);
                    allDepartments.Add(department);

                }

                return allDepartments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Department>();
            }
            finally
            {
                conn.Close();
            }

        }
        public static void EditDepartmentDetails(int id, string departmentName)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string sql = "UPDATE `departments` SET `DeptID` = @id ,`DeptName` = @deptName";
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.AddWithValue("@deptName", MySqlDbType.String).Value = departmentName;


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                //conn.Close();
            }
            finally
            {
                conn.Close();
            }

        }
        public static void DeleteDepartment(int id)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(Config.conString);
                string sql = "delete from dbi434661.departments where DeptId=@DeptId";

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@DeptId", MySqlDbType.Int32).Value = id;//ID

                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted!");
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
            //finally
            //{

            //}

        }
        public static void GetDepartmentById()
        {

        }
    }
}
