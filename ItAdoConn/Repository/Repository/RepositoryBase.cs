using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItAdoConn.Data;
using ItAdoConn.Models;
using ItAdoConn.Repository.Interface;

namespace ItAdoConn.Repository.Repository
{
    public class RepositoryBase
    {
        public dynamic GetById<T>(string cmd)
        {
            return ConnDapper.Get<T>(cmd);
        }
        public dynamic GetList<T>(string cmd)
        {
            return ConnDapper.Get<T>(cmd);
        }
        public dynamic Query(string cmd)
        {

            return ConnDapper.Query(cmd);
        }
    }

}
