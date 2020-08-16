using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;
using LibItEasyUtility.Controllers;

namespace LibItEasyUtility.VarLib
{
    public static class Var
    {
        public static string LibCaption ="ItEasy - Serviços de Informática";
        public static List<ConexaoModels> objListConexao
        {
            get
            {
                ConexaoCotrollers ctrl = new ConexaoCotrollers();
                return ctrl.CargaVariable();
            }
        }
        public static string objConexaoSelected { set; get; }
        
        public static List<DataBasesModels> objListDatabases
        {
            get
            {
                DatabasesControllers ctrl = new DatabasesControllers();
                return ctrl.GetListView();
            }
        }

        public static List<TablesModels> objListTables
        {
            get
            {
                TablesControllers ctrl = new TablesControllers();
                return ctrl.GetListView();
            }
        }
        private static List<ColumnsModels> _objListColumns;
        public static List<ColumnsModels> objListColumns
        {
            get
            {
                ColumnsControllers ctrl = new ColumnsControllers();
                _objListColumns= ctrl.GetList().ToList();
                return ctrl.GetList().ToList();
            }
        }

        public static DataBasesModels objDatabaseSelected { set; get; }
        public static TablesModels objTablesSelected { set; get; }
    }
}
