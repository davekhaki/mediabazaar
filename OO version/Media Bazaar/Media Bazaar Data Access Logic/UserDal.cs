using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Data_Access_Logic
{
    public class UserDal
    {
        private string sql;
        private readonly DbHelper dbHelper = new DbHelper();

        public DataTable GetAllEmployees()
        {
            sql = $"SELECT * FROM employee e INNER JOIN login l ON e.id = l.empid";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                var reader = dbHelper.Cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employees:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
            return null;
        }

        public DataTable GetEmployeeDetails(string username)
        {
            sql = $"SELECT * FROM employee e INNER JOIN login l ON e.id = l.empid WHERE l.username = '{username}'";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                //dbHelper.cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                var reader = dbHelper.Cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting personal details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
            return null;          
        }

        public void UpdateUsername(string oldUsername, string newUsername)
        {
            sql = $"UPDATE login SET username = @newUsername WHERE username = @oldUsername";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@oldUsername", MySqlDbType.String).Value = oldUsername;
                dbHelper.Cmd.Parameters.Add("@newUsername", MySqlDbType.String).Value = newUsername;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing username:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public void UpdatePassword(string username, string newPassword)
        {
            sql = $"UPDATE login SET password = @password WHERE username = @username";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@password", MySqlDbType.String).Value = newPassword;
                dbHelper.Cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error changing password:"+ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public DataTable GetSchedules()
        {
            sql = "SELECT * FROM schedule";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                var reader = dbHelper.Cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting schedules:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }

            return null;
        }

        public DataTable GetSchedulesForEmp(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }
    }
}
