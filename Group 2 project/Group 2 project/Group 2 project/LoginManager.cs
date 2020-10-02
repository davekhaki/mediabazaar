using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2_project
{
    public class LoginManager
    {
        
        public bool Login(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT * FROM login WHERE username = '{username}'", conn);

            conn.Open();

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                string retrieved = reader.GetString(2);
                if (retrieved == password)
                {
                    //success
                    return true;

                }
                else
                {
                    return false;
                }
                
            }
            conn.Close();
            return true;
        }

        public string GetRole(string username)
        {
            string role = "";
            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout=30;user id=dbi434661; pwd=daivbot");
            MySqlCommand query = new MySqlCommand($"SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE username = '{username}'", conn);

            conn.Open();

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                role = reader.GetString(0);
                
            }
            return role;



        }
    }
}
