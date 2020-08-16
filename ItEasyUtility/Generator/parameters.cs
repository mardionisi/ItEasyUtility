using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;

namespace ItEasyUtility.Generator
{
    public class parameters
    {
        public string criarparamentos(List<ColumnsModels> lst)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            sb.Append("using System.Data.SqlClient;\r\n");
            sb.Append("using <localização da sua Models>;\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");

            sb.Append("string cmd = \" <sua procedures> \"\r\n");
            sb.Append("List<SqlParameter> Params = new List<SqlParameter>();\r\n");

            lst.ForEach(delegate (ColumnsModels rw)
            {
                sb.Append("Params.Add(new SqlParameter(\"@" + rw.name + "\",obj." + rw.ColumnOwner + "));\r\n");
            });

            return sb.ToString();
        }
    }
}
