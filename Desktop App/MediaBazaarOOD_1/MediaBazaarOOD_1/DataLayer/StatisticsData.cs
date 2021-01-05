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
    public class StatisticsData
    {
        public static List<Person> GetAllPersons()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string sql = "SELECT * FROM employee";
            List<Person> persons = new List<Person>();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();
                    int age = Convert.ToInt32(dr[3]);
                    string gender = dr[4].ToString();
                    string dName = dr[5].ToString();
                    DateTime hireDate = Convert.ToDateTime(dr[6]);
                    // DateTime endDate = Convert.ToDateTime(dr[7]);

                    int salary = Convert.ToInt32(dr[8]);
                    string address = dr[9].ToString();
                    string role = dr[10].ToString();

                    Person person = new Person(firstName, lastName, age, gender, dName, hireDate, salary, address, role);
                    persons.Add(person);
                }
                return persons;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Person>();
            }
            finally
            {
                conn.Close();
            }
        }
        //     public static void autoLoadSalaryChart()
        // {
        //     MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
        //     string query = "SELECT DepartmentName, SUM(Salary) AS 'totalSalary' FROM employee GROUP BY DepartmentName";
        //     MySqlCommand command = new MySqlCommand(query, conn);
        //     MySqlDataReader reader;

        //     try
        //     {
        //         conn.Open();
        //         reader = command.ExecuteReader();


        //         while (reader.Read())
        //         {
        //             this.chart6.Series["Salary"].Points.AddXY(reader.GetString("DepartmentName"), reader.GetInt32("totalSalary"));

        //         }


        //     }
        //     catch (Exception ex)
        //     {

        //         MessageBox.Show(ex.Message);
        //     }
        //     finally { conn.Close(); }

        // }

        //public static void autoLoadSchedulesChart()
        // {
        //     MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
        //     string query = "SELECT concat(e.FirstName,' ', e.LastName) AS 'Employee Name', COUNT(s.EmployeeID) AS 'Shifts Worked' FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID GROUP BY e.FirstName";
        //     MySqlCommand command = new MySqlCommand(query, conn);
        //     MySqlDataReader reader;

        //     try
        //     {
        //         conn.Open();
        //         reader = command.ExecuteReader();


        //         while (reader.Read())
        //         {
        //             this.chart2.Series["Employee Name"].Points.AddXY(reader.GetString("Employee Name"), reader.GetInt32("Shifts Worked"));

        //         }


        //     }
        //     catch (Exception ex)
        //     {

        //         MessageBox.Show(ex.Message);
        //     }
        //     finally { conn.Close(); }
        // }
    }
}
