using MediaBazaarOOD_1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaarOOD_1.DataLayer
{
    public static class PersonData
    {
        private static object ID;

        public static void AddPerson(Person person)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");

                string query = "INSERT INTO `login`(`username`, `password`) VALUES (@username,@password);" +
                    "insert into dbi434661.employee(`FirstName`,`LastName`, `Age`, `Gender`, `DepartmentName`, `HireDate`, `Salary`,`Address`, `Role`) VALUES(@FirstName,@LastName,@Age,@Gender,@HireDate,@DepartmentName,@Salary,@Address,@Role)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@username", username);
                //cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                cmd.Parameters.AddWithValue("@LastName", person.LastName);
                cmd.Parameters.AddWithValue("@Age", person.Age);
                cmd.Parameters.AddWithValue("@Gender", person.Gender);
                cmd.Parameters.AddWithValue("@DepartmentName", person.DepartmentName);
                cmd.Parameters.AddWithValue("@HireDate", person.HireDate);
                //cmd.Parameters.AddWithValue("@EndDate", person.EndDate);
                cmd.Parameters.AddWithValue("@Salary", person.Salary);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                cmd.Parameters.AddWithValue("@Role", person.Role);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static List<Person> GetAllPersons()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            string sql = "SELECT * FROM employee";
            List<Person> persons = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
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
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public static void EditPersonDetails(string firstName, string lastName, int age, string gender, string dName, DateTime hireDate, int salary, string address, string role)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
                string sql = "UPDATE `employees` SET `FirstName` = @firstName, `LastName` = @lastName, `Age` = @age, `Gender` = @gender, `DepartmentName` = @dName, `HireDate` = @hireDate, `Salary` = @salary, `Address` = @address, `Role` = @role  WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DepartmentName", dName);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                //cmd.Parameters.AddWithValue("@EndDate", person.EndDate);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Role", role);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
        public static bool LoginUser(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT * FROM login WHERE username = @username";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string retrieved = reader.GetString(2);
                    if (retrieved == password) //given password matches the password in the database for the given username
                    {
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return false;
        }


        public static void ChangePassword(string username, string oldPassword, string newPassword)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "UPDATE login SET password = @newPass WHERE password = @oldPass AND username = @username";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@newPass", MySqlDbType.String).Value = newPassword;
                cmd.Parameters.Add("@oldPass", MySqlDbType.String).Value = oldPassword;
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;

                cmd.ExecuteNonQuery();
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
        public static string GetRole(string username)
        {
            string role = "";
            MySqlConnection conn = new MySqlConnection(Config.conString);
            MySqlCommand query = new MySqlCommand($"SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = '{username}'", conn);

            conn.Open();

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                role = reader.GetString(0);
            }

            conn.Close();
            return role;
        }
        public static void UpdateSalary(int id, double salary)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE `employees` SET `salary` = @salary WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public static void DeletePersonDetails()
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "delete from dbi434661.employee where EmployeeId=@ID";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Deleted successfully!");

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
        public static void GetPersonsPosition()
        {

        }

       
    }
}
