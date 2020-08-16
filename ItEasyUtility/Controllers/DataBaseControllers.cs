using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Repository.Repository;
using ItEasyUtility.Models;

namespace ItEasyUtility.Controllers
{
    public class DataBaseControllers : RepositoryBase
    {
        public List<DataBaseModels> GetListView()
        { 
            string cmd = "select name,database_id,collation_name from sys.databases WHERE owner_sid<>0x01 ORDER BY name";

            return GetList<DataBaseModels>(cmd);
        }
    }
}
