using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOO;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Data
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
