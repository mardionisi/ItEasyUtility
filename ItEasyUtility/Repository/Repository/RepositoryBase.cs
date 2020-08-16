using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Data;
using ItEasyUtility.Models;
using ItEasyUtility.Repository.Interface;
namespace ItEasyUtility.Repository.Repository
{
    public class RepositoryBase : IRepositoryBase
    {
        public dynamic GetById<T>(string cmd)
        {

            return ConnDapper.Get<T>(cmd, Var.strConexao);
        }
        public dynamic GetList<T>(string cmd)
        {

            return ConnDapper.Get<T>(cmd, Var.strConexao);
        }
        public dynamic Query(string cmd)
        {

            return ConnDapper.Query(cmd, Var.strConexao);
        }

    }
}
