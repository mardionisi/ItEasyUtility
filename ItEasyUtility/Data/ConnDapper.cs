using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using ItEasyUtility.Models;
using Dapper;
using System.Data;

namespace ItEasyUtility.Data
{
    public class ConnDapper
    {
        static SqlConnection conexaoBD { set; get; }

        static ConnDapper()
        {
            conexaoBD = new SqlConnection(Var.strConexao);

        }

        static void OpenConnection()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
            {
                conexaoBD.Open();
            }
        }
        static void CloseConnection()
        {
            if (conexaoBD.State == ConnectionState.Open)
            {
                conexaoBD.Close();
            }
        }
        public static dynamic GetList<T>(string cmd, string conexaoGerador = "")
        {

            conexaoBD = new SqlConnection(conexaoGerador);


            return conexaoBD.Query<T>(cmd);
        }
        public static dynamic Get<T>(string cmd, string conexaoGerador = "")
        {

            conexaoBD = new SqlConnection(conexaoGerador);


            return conexaoBD.Query<T>(cmd);
        }
        public static dynamic Query(string cmd, string conexaoGerador = "")
        {

            conexaoBD = new SqlConnection(conexaoGerador);


            return conexaoBD.Query(cmd);
        }
    }
}
