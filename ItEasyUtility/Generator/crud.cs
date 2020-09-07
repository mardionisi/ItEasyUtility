using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;

namespace ItEasyUtility.Generator
{
    public class crud
    {
        public string criarcrud(List<ColumnsModels> lst, string table,string mynamespace)
        {
            StringBuilder sb = new StringBuilder();
            string concat = "";
            string values = "";
            string ordemstr = "";
            Int32 ordem = 0;

            sb.Append("\r\n");
            sb.Append("using System.Data.SqlClient;\r\n");
            sb.Append($"using {mynamespace}.Models;\r\n");
            sb.Append($"using {mynamespace}.Repositories;\r\n");
            sb.Append("\r\n");

            sb.Append("private Int32 back=0; \r\n");
            sb.Append("private " + table + "Models objModel = new " + table + "Models(); \r\n");
            sb.Append("private List<" + table + "Models> objLstModel = new List<" + table + "Models>(); \r\n");
            sb.Append("private " + table + "Repository objCtrl = new " + table + "Repository(); \r\n");
            sb.Append("\r\n");
            /*
             * INSERT
            */
            sb.Append("public Int32 Insert(" + table + "Models obj) { \r\n");
            sb.AppendFormat("string cmd = string.Format(@\"INSERT INTO {0}(", table);
            lst.ForEach(delegate (ColumnsModels rw)
            {
                ordemstr += ConvertToOrdemByString(rw.TypeNameConvert, ordem);
                values += "\r\n obj." + rw.name + ",";  //ConvertToString(rw.TypeNameConvert, rw.name, ordem);
                concat += "\r\n " + rw.name + ",";
                ordem += 1;
            });
            concat = concat.Substring(0, concat.Length - 1);
            values = values.Substring(0, values.Length - 1);
            ordemstr = ordemstr.Substring(0, ordemstr.Length - 1);

            sb.AppendFormat("{0} \r\n  ) VALUES (", concat);
            sb.AppendFormat("{0})\",", ordemstr);
            sb.AppendFormat("{0})\r\n", values);
            sb.Append("objCtrl.Insert(objModel);\r\n");
            sb.Append("}\r\n");
            //sb.Append("string cmd = \" <sua procedures> \"\r\n");
            //sb.Append("List<SqlParameter> Params = new List<SqlParameter>();\r\n");

            //lst.ForEach(delegate (ColumnsModels rw)
            //{
            //    sb.Append("Params.Add(new SqlParameter(\"@" + rw.name + "\",obj." + rw.ColumnOwner + "));\r\n");
            //});

            return sb.ToString();
        }
        string[] ConvertToString(string TypeNameConvert, string name, Int32 ordem)
        {
            string[] values = new string[1]; 
            switch (TypeNameConvert)
            {
                case "Int32":
                    values[0] = "\r\n obj." + name + ",";
                    values[1] = values[0];
                    break;

                case "double":
                    values[0] = "\r\n obj." + name + ",";
                    values[1] = values[0];
                    break;

                case "DateTime":
                    values[0] = "\r\n obj." + name + ",";
                    values[1] += "\r\n 'obj." + (name) + "ToString(\"yyyy-MM-dd hh: mm: ss\")',";
                    break;

                case "string":
                case "image":
                    values[0] = "\r\n 'obj." + name + "',";
                    values[1] += "\r\n 'obj." + name + ".ToString()',";
                    break;

                default:
                    values[0] = "\r\n **obj." + name + "**,";
                    break;

            }

            return values;
        }
        string ConvertToOrdemByString(string TypeNameConvert, Int32 ordem)
        {
            string values = "";
            switch (TypeNameConvert)
            {
                case "Int32":
                    values += "\r\n {" + ordem.ToString() + "},";
                    break;

                case "double":
                    values += "\r\n {" + ordem.ToString() + "},";
                    break;

                case "DateTime":
                    values += "\r\n {" + ordem.ToString() + ".ToString(\"yyyy-MM-dd hh: mm: ss\")},";
                    break;

                case "string":
                case "image":
                    values += "\r\n '{" + ordem.ToString() + ".ToString()}',";
                    break;

                default:
                    values += "\r\n **{" + ordem.ToString() + ".ToString()}**,";
                    break;

            }

            return values;
        }
    }
}
