using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FoodPlatform
{
    internal class DBconn
    {
        public MySqlConnection Connection()
        {
            // 데이터 연결을 위한
            string connectionString = null;
            MySqlConnection conn;

            connectionString = "Server=localhost;Database=foodplatform;Uid=root;Pwd=test1234";
            conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
