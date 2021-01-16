using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
    
namespace binek
{
    class HelperDB
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=rentacar; uid=root;pwd=123456");
        public MySqlConnection Connection()
        {
            return conn;
        }
    }
}
