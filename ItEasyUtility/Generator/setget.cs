using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;

namespace ItEasyUtility.Generator
{
    public class setget
    {
        public string gerarpropriedades(List<ColumnsModels> lst)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            foreach (ColumnsModels rw in lst)
            {
                sb.Append("public " + rw.TypeNameConvert + " " + rw.ColumnOwner + "{ set; get; }\r\n");

    }
            sb.Append("\r\n"); sb.Append("\r\n");

            return sb.ToString();
        }
    }
}
