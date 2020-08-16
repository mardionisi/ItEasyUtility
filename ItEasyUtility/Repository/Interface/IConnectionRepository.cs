using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Models;

namespace ItEasyUtility.Repository.Interface
{
    public interface IConnectionRepository
    {
        ConnectionModels GetById(int Id);
        ConnectionModels Load(int Id);
        void Save(ConnectionModels Connection);
        void Delete(ConnectionModels Connection);
    }
}
