using MySql.Data.MySqlClient;

namespace Media_Bazaar_Data_Access_Logic
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
