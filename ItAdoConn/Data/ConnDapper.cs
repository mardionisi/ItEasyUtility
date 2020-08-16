using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using ItAdoConn.Models;
using Dapper;
using System.Data;

namespace ItAdoConn.Data
{
    public class ConnDapper
    {

        static SqlConnection conexaoBD { set; get; }

        static ConnDapper()
        {
            conexaoBD = new SqlConnection(ItVarSqL.objConexaoSelected);

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
        public static dynamic GetList<T>(string cmd)
        {

            conexaoBD = new SqlConnection(ItVarSqL.objConexaoSelected);


            return conexaoBD.Query<T>(cmd);
        }
        public static dynamic Get<T>(string cmd)
        {

            conexaoBD = new SqlConnection(ItVarSqL.objConexaoSelected);


            return conexaoBD.Query<T>(cmd);
        }
        public static dynamic Query(string cmd)
        {

            conexaoBD = new SqlConnection(ItVarSqL.objConexaoSelected);


            return conexaoBD.Query(cmd);
        }
    }
} 
   