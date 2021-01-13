using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOO;
using MediaBazaarOO.Entities;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Data
{
    public class ScheduleData
    {
        public static List<Schedule> GetAllSchedules()
        {
            var conn = new MySqlConnection(Config.ConString);
            var sql = "SELECT * FROM schedule";
            var schedules = new List<Schedule>();
            try
            {
                var cmd = new MySqlCommand(sql, conn);
                conn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var timeOfDay = dr.GetString(1);
                    var empId = Convert.ToInt32(dr[0]);
                    var date = Convert.ToDateTime(dr[2]);
                    var schedule = new Schedule(empId, date, timeOfDay);
                    schedules.Add(schedule);

                }
                return schedules;
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

        //adding a schedule 
        public static void AddSchedule(Schedule s)
        {
            var conn = new MySqlConnection(Config.ConString);
            var sql = "INSERT INTO schedule(EmployeeID, TimeOfDay, Day) VALUES (@EmpId, @Time, @Day)";
            try
            {
                conn.Open();
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@EmpId", MySqlDbType.Int32).Value = s.EmpId;
                cmd.Parameters.Add("@Time", MySqlDbType.String).Value = s.TimeOfDay;
                cmd.Parameters.Add("@Day", MySqlDbType.Date).Value = s.Day;

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
    }
}
