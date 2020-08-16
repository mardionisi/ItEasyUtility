using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItEasyUtility.Repository.Interface
{
   public interface IRepositoryBase
    {
        dynamic GetById<T>(string cmd);
        dynamic GetList<T>(string cmd);
        dynamic Query(string cmd);
    }
}
