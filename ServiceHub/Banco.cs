using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ServiceHubClass;

namespace ServiceHub
{
    public static class Banco 
    {
        // string de conexão com o banco de dados (Mariadb)
        public static string? StrConn { get; set; }

        // método para abrir conexão com banco - entrega uma conexão aberta,
        // no objeto de comandos Sql (Um objeto do tipo MySqlCommand)
        public static MySqlCommand Abrir(string strconn = "")
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConn = strconn;
            if(StrConn == string.Empty)
                StrConn = $@"server=10.91.47.48;database=comercialti101;user=root;password=P@ssw0rd";
            MySqlConnection cn = new(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);              
            }
            return cmd;
        }


    }
}
