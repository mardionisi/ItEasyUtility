using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItEasyUtility.Models;

namespace ItEasyUtility.Models
{
    public class Var

    {
        public static string frmAplicativo { get; set; }
        public static string strConexao { get; set; }
        public static List<DataBaseModels> objListDatabases { get; set; }
        public static List<TablesModels> objListTables { get; set; }
        public static List<ColumnsModels> objListColumns { get; set; }
        public static List<ConexaoModels> objListConexao { get; set; }
        //public static string objNameSelected { set; get; }

        public static List<pesquisacolumnsModels> objListPesquisa { get; set; }
        public static string objDataBaseSelected { set; get; }
        public static string objFieldSelected { set; get; }
        public static string objValorSelected { set; get; }
      
        public static Form itEasyFrm { set; get; }

        static Var()
        {
            strConexao = @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename = D:\TeamDionisi\Contabil\iteasycontabil\ItEasyContabil\BancoDados\iTContabil.mdf; Integrated Security = True";
            frmAplicativo = "Meu Aplicativo WPF1App1";  
        }


        private static DataBaseModels _objSelectDataBase;
        public static DataBaseModels objSelectDataBase
        {
            get { return _objSelectDataBase; }
            set { _objSelectDataBase = value; }

        }
        private static TablesModels _objSelectTable;
        public static TablesModels objSelectTable 
        {
                get { return _objSelectTable; }
                set { _objSelectTable = value; }
            }
        }
      

}
