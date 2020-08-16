using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;
using ItAdoConn.Repository.Repository;

namespace LibItEasyUtility.Controllers
{
    public class TablesControllers : RepositoryBase
    {
        public List<TablesModels> GetListView()
        {
            string cmd = string.Format(@"SELECT name, object_id FROM {0}.sys.Tables WHERE Type='U' ORDER BY name",VarLib.Var.objDatabaseSelected.name);
            return GetList<TablesModels>(cmd);
        }
    }
}
