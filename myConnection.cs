﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2A1IDEXXXx
{
    public class MyConnection
    {
        public static MySqlConnection ObtenerConexion()
        {

          MySqlConnection conectar = new MySqlConnection (“server = 127.0.0.1; database = Tutorial; Uid = root; pwd =;”);

            conectar.Open();

            return conectar;
        }
    }
}
