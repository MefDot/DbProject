using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DbProject
{
    class Global
    {
        string strConnection = "server=localhost;user id=root;password=root;database=dbproject";

        public string CheckConnection()
        {
            string answer = string.Empty;
            using(MySqlConnection connection = new MySqlConnection(strConnection))
            {
                connection.Open();

                string SQL = "SELECT * FROM dbproject.people;";

                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                answer = cmd.ExecuteScalar().ToString();

            }

            return answer;


        } 


    }
}
