using MediaBazaarOOD_1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MediaBazaarOOD_1.DataLayer
{
    public class PersonData
    {
        //private static object ID;

        readonly DbHelper dbHelper = new DbHelper();

        public static void AddPerson(Person person)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");

                string query = "insert into dbi434661.employee(`FirstName`,`LastName`, `Age`, `Gender`, `DepartmentName`, `HireDate`, `Salary`,`Adress`, `Role`) VALUES(@FirstName,@LastName,@Age,@Gender,@DepartmentName,@HireDate,@Salary,@Adress,@Role)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                cmd.Parameters.AddWithValue("@LastName", person.LastName);
                cmd.Parameters.AddWithValue("@Age", person.Age);
                cmd.Parameters.AddWithValue("@Gender", person.Gender);
                cmd.Parameters.AddWithValue("@DepartmentName", person.DepartmentName);
                cmd.Parameters.AddWithValue("@HireDate", person.HireDate);
                //cmd.Parameters.AddWithValue("@EndDate", person.EndDate);
                cmd.Parameters.AddWithValue("@Salary", person.Salary);
                cmd.Parameters.AddWithValue("@Adress", person.Address);
                cmd.Parameters.AddWithValue("@Role", person.Role);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=dbi434661;uid=root;");
                string sql = "SELECT * FROM employee";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0].ToString());
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

                    Person person = new Person(id, firstName, lastName, age, gender, dName, hireDate, salary, address, role);
                    persons.Add(person);
                }
                conn.Close();
                return persons;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return persons;

            }


        }
        public void EditPersonDetails(int id, string FirstName, string LastName, int Age, string Gender, string DepartmentName, DateTime HireDate, int Salary, string Adress, string Role)
        {
            try
            {

                string sql = "UPDATE dbi434661.employee SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Gender = @Gender, DepartmentName = @DepartmentName, HireDate = @HireDate, Salary = @Salary, Adress = @Adress, Role = @Role WHERE id = @id";
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);

                dbHelper.Cmd.Parameters.AddWithValue("@id", id);
                dbHelper.Cmd.Parameters.AddWithValue("@FirstName", FirstName);
                dbHelper.Cmd.Parameters.AddWithValue("@LastName", LastName);
                dbHelper.Cmd.Parameters.AddWithValue("@Age", Age);
                dbHelper.Cmd.Parameters.AddWithValue("@Gender", Gender);
                dbHelper.Cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                dbHelper.Cmd.Parameters.AddWithValue("@HireDate", HireDate);
                //cmd.Parameters.AddWithValue("@EndDate", EndDate);
                dbHelper.Cmd.Parameters.AddWithValue("@Salary", Salary);
                dbHelper.Cmd.Parameters.AddWithValue("@Adress", Adress);
                dbHelper.Cmd.Parameters.AddWithValue("@Role", Role);

                dbHelper.Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally {
                dbHelper.Conn.Close();
            }

        }
       

        public static void DeletePersonDetails()
        {
            //MySqlConnection conn = new MySqlConnection(Config.conString);
            //string sql = "delete from dbi434661.employee where EmployeeId=@ID";

            //try
            //{
            //    conn.Open();

            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

            //    cmd.ExecuteNonQuery();
            //    //MessageBox.Show("Deleted successfully!");

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.ToString());
            //}
            //finally
            //{
            //    conn.Close();
            //}

        }

        public static Person GetPersonByID(int empId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");

                string sql = "SELECT FirstName, LastName,Age,Gender,DepartmentName,HireDate,Salary,Adress,Role FROM `employee` WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", empId);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Person p = null;


                while (dataReader.Read())
                {
                    string firstName = dataReader[1].ToString();
                    string lastName = dataReader[2].ToString();
                    int age = Convert.ToInt32(dataReader[3]);
                    string gender = dataReader[4].ToString();
                    string dName = dataReader[5].ToString();
                    DateTime hireDate = Convert.ToDateTime(dataReader[6]);
                    // DateTime endDate = Convert.ToDateTime(dataReader[6]);
                    int salary = Convert.ToInt32(dataReader[8]);
                    string address = dataReader[9].ToString();
                    string role = dataReader[10].ToString();


                    p = new Person(firstName, lastName, age, gender, dName, hireDate, salary, address, role);

                }

                conn.Close();

                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }
        public static List<int> GetAllIds()
        {
            List<int> ids = new List<int>();
            try
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
                string sql = "SELECT ID FROM employee";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    int id = Convert.ToInt32(dr[0]);


                    //Person person = new Person(firstName, lastName, age, gender, dName, hireDate, salary, address, role);
                    ids.Add(id);
                }
                conn.Close();
                return ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ids;

            }

        }

    }
}
