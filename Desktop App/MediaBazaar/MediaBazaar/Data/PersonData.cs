using System;
using System.Collections.Generic;
using System.Text;
using MediaBazaarOO.Entities;
using MySql.Data.MySqlClient;

namespace MediaBazaarOO.Data
{
    public static class PersonData
    {
        public static void AddPerson(Person person)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Config.ConString);

                string query = "INSERT INTO `login`(`username`, `password`) VALUES (@username,@password);" +
                    "insert into dbi434661.employee(`FirstName`,`LastName`, `Age`, `Gender`, `DepartmentName`, `HireDate`, `Salary`,`Address`, `Role`) VALUES(@FirstName,@LastName,@Age,@Gender,@HireDate,@DepartmentName,@Salary,@Address,@Role)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", "temporaryUsername");
                cmd.Parameters.AddWithValue("@password", "temporaryPassword");
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
            MySqlConnection conn = new MySqlConnection(Config.ConString);
            string sql = "SELECT * FROM employee";
            List<Person> persons = new List<Person>();

            try
            {
                var today = DateTime.Today;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();
                    DateTime dob = Convert.ToDateTime(dr[3]);
                    var age = today.Year - dob.Year;

                    string gender = dr[4].ToString();
                    string dName = dr[5].ToString();
                    DateTime hireDate = Convert.ToDateTime(dr[6]);
                    // DateTime endDate = Convert.ToDateTime(dr[7]);
                    int salary = Convert.ToInt32(dr[8]);
                    string address = dr[9].ToString();
                    string role = dr[10].ToString();

                    Person person = new Person(firstName, lastName, age, gender, dName, hireDate, salary, address, role);
                    person.Id = dr.GetInt32(0);
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
                MySqlConnection conn = new MySqlConnection(Config.ConString);
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

        public static void ChangePassword(string username, string oldPassword, string newPassword)
        {
            MySqlConnection conn = new MySqlConnection(Config.ConString);
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

        public static void UpdateSalary(int id, double salary)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Config.ConString);
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
        public static void DeletePersonDetails(int id)
        {
            MySqlConnection conn = new MySqlConnection(Config.ConString);
            string sql = "delete from dbi434661.employee where EmployeeId=@ID";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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


        public static int ValidateUsernamePassword(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(Config.ConString);
            string sql = "SELECT * FROM login WHERE username = @username AND password = @password";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string valid = reader.GetString(2);
                    if (valid == password)
                    {
                        return 1;
                    }
                    else return 0;
                }

                return -1;
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
            var role = "";
            var sql = "SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = @username";
            var conn = new MySqlConnection(Config.ConString);
            var query = new MySqlCommand(sql, conn);
            query.Parameters.Add("@username", MySqlDbType.String).Value = username;
            try
            {
                conn.Open();

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    role = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }
            return role;
        }

        public static int GetIdFromUsername(string username)
        {
            var id = 0;
            var sql = "SELECT e.ID FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = @username";
            var conn = new MySqlConnection(Config.ConString);
            var query = new MySqlCommand(sql, conn);
            query.Parameters.Add("@username", MySqlDbType.String).Value = username;
            try
            {
                conn.Open();

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }
            return id;
        }

        public static void UpdatePreference(int id, SchedulePreference p)
        {
            var sql = "UPDATE employee SET MorningPreference = @morning, AfternoonPreference = @afternoon, EveningPreference = @evening WHERE employee.ID = @id";
            var conn = new MySqlConnection(Config.ConString);
            var cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.Add("@morning", MySqlDbType.Int16).Value = Convert.ToInt16(p.WorkMorning);
                cmd.Parameters.Add("@afternoon", MySqlDbType.Int16).Value = Convert.ToInt16(p.WorkAfternoon);
                cmd.Parameters.Add("@evening", MySqlDbType.Int16).Value = Convert.ToInt16(p.WorkEvening);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<bool> GetPreference(int id)
        {
            var list = new List<bool>();
            var sql = "SELECT MorningPreference, AfternoonPreference, EveningPreference FROM employee WHERE ID = @id";
            var conn = new MySqlConnection(Config.ConString);
            var query = new MySqlCommand(sql, conn);
            query.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            try
            {
                conn.Open();

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    var morning = Convert.ToBoolean(Convert.ToInt16(reader.GetInt32(0)));
                    var afternoon = Convert.ToBoolean(Convert.ToInt16(reader.GetInt32(1)));
                    var evening = Convert.ToBoolean(Convert.ToInt16(reader.GetInt32(2)));
                    list.Add(morning);
                    list.Add(afternoon);
                    list.Add(evening);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }
            return list;
        }
    }
}
