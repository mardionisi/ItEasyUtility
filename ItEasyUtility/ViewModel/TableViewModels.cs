using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ItEasyUtility.Models;
using ItEasyUtility.Controllers;

namespace ItEasyUtility.ViewModel  
{
    public class TableViewModels : ObservableCollection<TablesModels>
    {
        public TableViewModels()
        {
         
        }

        public List<TablesModels> GetList()
        {                      
            TablesControllers objRep = new TablesControllers();
            return  objRep.GetList();

        }
    }
}

