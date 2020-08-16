using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;
using ItAdoConn.Repository.Repository;


namespace LibItEasyUtility.Controllers
{
    public class DatabasesControllers : RepositoryBase
    {
        public List<DataBasesModels> GetListView()
        {
            string cmd = "select name,database_id,collation_name from sys.databases WHERE owner_sid<>0x01 ORDER BY name";

            return GetList<DataBasesModels>(cmd);
        }
    }
}
