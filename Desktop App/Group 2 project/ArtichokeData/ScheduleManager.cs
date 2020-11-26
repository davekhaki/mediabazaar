using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace ArtichokeData.employee
{
    public class ScheduleManager
    {
        /*------------- all the schedule related data access -------------*/

        //get schedules for chosen week
        public void GetWeeklySchedule(string username, DataGridView dataGrid, DateTime yearweek)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT s.TimeOfDay, s.Day FROM((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l on l.empId = e.ID) WHERE l.username = @username AND YEARWEEK(DAY) = YEARWEEK(@yearweek)";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@yearweek", MySqlDbType.DateTime).Value = yearweek;

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //getting schedules on manager side by first and last name
        public void GetScheduleByName(DataGridView dataGrid, string firstName, string lastName)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT e.FirstName, e.LastName, s.EmployeeID, s.TimeOfDay, s.Day FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID WHERE e.FirstName = @First AND LastName = @Last";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@First", MySqlDbType.String).Value = firstName;
                cmd.Parameters.Add("@Last", MySqlDbType.String).Value = lastName;

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //adding a schedule based on first and last name
        public void AddSchedule(string firstName, string lastName, string timeOfDay, DateTimePicker dateTimePicker)
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
                cmd2.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker.Text;

                conn.Open();
                int affectedRows = cmd2.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    MessageBox.Show("Error adding the shift");
                }
                else MessageBox.Show("Shift added successfully!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public DateTime[] TestGetSchedule(string username)
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();    
                
            }
            DateTime[] daysArray = daysList.ToArray();
            return daysArray;
        }

        public void GetScheduleTime(DataGridView dataGrid, string username, DateTime day)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT s.TimeOfDay FROM((employee e INNER JOIN schedule s ON e.ID = s.EmployeeID) INNER JOIN login l on l.empId = e.ID) WHERE l.username = @username AND s.Day = @day";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@day", MySqlDbType.DateTime).Value = day;

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }
   }
}
