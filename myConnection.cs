using MySql.Data.MySqlClient;
using System;


namespace U2A1IDEXXXx
{
    public class MyConnection
    {
         public static MySqlConnection GetConnection() // Metodo para hacer conexion
        {
              MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=dbu3mala; Uid=root; pwd=;");  //String de conexion
              connector.Open();
               return connector;
       }

    }
}
