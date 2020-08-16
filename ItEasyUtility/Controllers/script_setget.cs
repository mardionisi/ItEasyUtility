using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Models;
namespace ItEasyUtility.Controllers
{
    public class script_setget
    {
        public void buidScriptSQL(List<ColumnsModels> objListCol)
        {
            StringBuilder frm = new StringBuilder();
            foreach (ColumnsModels rw in objListCol)
            {

                frm.Append(generate_cSharp(rw.TypeNameConvert, rw.name));

            }

        }
    
        public string generate_cSharp(string TipoField, string field)
        {
            string fieldBack = string.Format(@"private {0} _{1}; 
             public  {0}  {1}
              {{
                get => _{1};
                set
                {{            
                         _{1} = value;
                    }}
                }}
            }}        

            return fieldBack;}}", TipoField, field);
            return fieldBack;
        }

    }

}
