using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ArtichokeData
{
    public class LoginManager
    {
        /*------------- all the login related data access -------------*/

        MySqlConnection conn = new MySqlConnection(Config.conString);

        public bool Login(string username, string password)
        {         
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
                        if (IsRetired(username) == false)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("This employee is retired, please contact a system administrator if this is a mistake.");
                            return false;
                        }                      
                    }
                    else //the password doesnt match
                    {
                        conn.Close();
                        MessageBox.Show("The username or password given is incorrect, please try again.");
                        return false;
                    }
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
            MessageBox.Show("The username or password given is incorrect, please try again.");
            return false;
        }

        public bool IsRetired(string username)
        {
            string sql = "SELECT e.EndDate FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = @username";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = username;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //DateTime? with ? means nullable
                    DateTime? retireDate = reader.IsDBNull(0) ? null : (DateTime?)reader.GetDateTime(0);
                    if (retireDate != null)
                    {
                        if (retireDate > DateTime.Now) return false;
                        else return true;
                    }
                    else return false;               
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
            return false;
        }

        public string GetRole(string username)
        {
            string role = "";
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

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
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
            catch( Exception ex)
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
