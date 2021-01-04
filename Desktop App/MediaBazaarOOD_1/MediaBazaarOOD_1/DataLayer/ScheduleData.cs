using MediaBazaarOOD_1.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.DataLayer
{
    public class ScheduleData
    {
        //About Schedules
        /*------------- all the schedule related data access -------------*/
        public static void AddSchedule(Schedule schedule)
        {

        }
        public static List<Schedule> GetAllSchedules()
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot"); ;
            string sql = "SELECT * FROM schedules";
            List<Schedule> allSchedules = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string timeOfDay = dr[2].ToString();
                    int eId = Convert.ToInt32(dr[1]);
                    DateTime date = Convert.ToDateTime(dr[3]);
                    Schedule schedule = new Schedule(eId, timeOfDay, date);
                    allSchedules.Add(schedule);

                }
                return allSchedules;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
                return new List<Schedule>();
            }
            finally
            {
                conn.Close();
            }

        }
        public static void EditScheduleDetails()
        {

        }
        public static void DeleteSchedule()
        {

        }
        public static void GetScheduleByEmployeeName()
        {

        }

        //get schedules for chosen week
        public static void GetWeeklySchedule(string username, DateTime yearweek)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT s.TimeOfDay, s.Day FROM((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l on l.empId = e.ID) WHERE l.username = @username AND YEARWEEK(DAY) = YEARWEEK(@yearweek)";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@yearweek", MySqlDbType.DateTime).Value = yearweek;
                //THIS CODE BELOW IS FRO FRONT END.............

                //MySqlDataAdapter sda = new MySqlDataAdapter();
                //sda.SelectCommand = cmd;
                //DataTable dbaTableset = new DataTable();
                //sda.Fill(dbaTableset);

                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = dbaTableset;
                //dataGrid.DataSource = bSource;

                //sda.Update(dbaTableset);
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

        //getting schedules on manager side by first and last name
        public static void GetScheduleByName(string firstName, string lastName)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT e.FirstName, e.LastName, s.EmployeeID, s.TimeOfDay, s.Day FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID WHERE e.FirstName = @First AND LastName = @Last";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@First", MySqlDbType.String).Value = firstName;
                cmd.Parameters.Add("@Last", MySqlDbType.String).Value = lastName;
                //THE CODE BELOW US FRO FRONT END
                //MySqlDataAdapter sda = new MySqlDataAdapter();
                //sda.SelectCommand = cmd;
                //DataTable dbaTableset = new DataTable();
                //sda.Fill(dbaTableset);

                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = dbaTableset;
                //dataGrid.DataSource = bSource;

                //sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);...THIS IS FOR FRONT END
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        //adding a schedule based on first and last name
        public static void AddSchedule(string firstName, string lastName, string timeOfDay)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);

            //first need a query to get the id based on the filled in name 
            string sql = "SELECT ID FROM employee WHERE FirstName = @First AND LastName = @Last";
            try
            {
                int empId = 0;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@First", MySqlDbType.String).Value = firstName;
                cmd.Parameters.Add("@Last", MySqlDbType.String).Value = lastName;

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empId = reader.GetInt32(0);
                }
                conn.Close();

                string sql2 = "INSERT INTO `schedule` (`EmployeeID`, `TimeOfDay`, `Day`) VALUES (@empId, @time, @date)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.Parameters.Add("@empId", MySqlDbType.Int32).Value = empId;
                cmd2.Parameters.Add("@time", MySqlDbType.String).Value = timeOfDay;
                //cmd2.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker.Text;//please replace this with a variable on the method

                conn.Open();
                int affectedRows = cmd2.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    // MessageBox.Show("Error adding the shift");...FOR FRONT END
                }
                else //MessageBox.Show("Shift added successfully!");...FOR FRONT END

                    conn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);...FOR FRONT END
            }
            finally
            {
                conn.Close();
            }

        }

        public static DateTime[] TestGetSchedule(string username)
        {
            List<DateTime> daysList = new List<DateTime>();

            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT s.Day FROM((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l on l.empId = e.ID) WHERE l.username = @username";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    daysList.Add(reader.GetDateTime(0));
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);..FOR FRONT END
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();

            }
            DateTime[] daysArray = daysList.ToArray();
            return daysArray;
        }

        public static void GetScheduleTime(string username, DateTime day)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT s.TimeOfDay FROM((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l on l.empId = e.ID) WHERE l.username = @username AND s.Day = @day";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@day", MySqlDbType.DateTime).Value = day;
                //THE CODE BELOW IS FOR FRONT END
                //MySqlDataAdapter sda = new MySqlDataAdapter();
                //sda.SelectCommand = cmd;
                //DataTable dbaTableset = new DataTable();
                //sda.Fill(dbaTableset);

                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = dbaTableset;
                //dataGrid.DataSource = bSource;

                //sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);...FOR FRONT END
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
