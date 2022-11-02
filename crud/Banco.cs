using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crud
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {

            var cn = new MySqlConnection();

            //Dados para conexão
            cn.ConnectionString += @"server= 127.0.0.1; database= crud; user id= root; password=;"; 
            cn.Open(); // Abri conexão

            var cmd = new MySqlCommand();
            cmd.Connection = cn;

            return cmd;

        }
    }
}
