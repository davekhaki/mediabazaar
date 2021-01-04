using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.DataLayer
{
    public class DbHelper
    {
        public MySqlConnection Conn;
        public MySqlCommand Cmd;

        public DbHelper()
        {
            Conn = new MySqlConnection(Config.ConString);
           Cmd = new MySqlCommand();
        }
    }
}
