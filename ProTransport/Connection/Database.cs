using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Connection
{
    class Database
    {
        static String Host { get { return "127.0.0.1"; } }
        static String Name { get { return "Transport"; } }
        static String Username { get { return "root"; } }
        static String Password { get { return ""; } }

        public static String ConnectionString
        {
            get { return String.Format("Server={0};Uid={1};Pwd={2};Database={3};", Host, Username, Password, Name); }
        }

        public static MySqlConnection Connection { get; protected set; }

        public static void Initialize()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

    }
}
