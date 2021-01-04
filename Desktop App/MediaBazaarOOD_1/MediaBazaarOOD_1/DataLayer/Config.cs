using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarOOD_1
{
    public static class Config
    {
        public static string conString = "server=localhost;database=dbi434661;uid=root;";

        public static string ConString { get; internal set; }

        //public static string conString = $"Persist Security Info=False;database=dbi434661;server=studmysql01.fhict.local;Connect Timeout = 30; user id = dbi434661; pwd=daivbot";
    }
}


