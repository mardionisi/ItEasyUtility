using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAdoConn.Models
{
    public class ConexaoModels
    {
        public string NomeConexao { set; get; }
        public string StringConexao { set; get; }

    }
    public static class ItVarSqL
    {

        public static List<ConexaoModels> objListConexao { set; get; }
        public static string objConexaoSelected { set; get; }
    }
}
