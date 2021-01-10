using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;
using ItAdoConn.Repository.Repository;
namespace LibItEasyUtility.Controllers
{
    public class ColumnsControllers :  RepositoryBase
    {
        public List<ColumnsModels> GetList()
        {
            string cmd = $@"SELECT  ty.name as TypeName,
                                tab.name as TableName, col.object_id, col.name, col.column_id, col.system_type_id, col.user_type_id, col.max_length, col.precision, 
                                col.scale, col.collation_name, col.is_nullable,'' as ColumnOwner
                                FROM [{VarLib.Var.objDatabaseSelected.name}].sys.columns col
                                INNER JOIN [{VarLib.Var.objDatabaseSelected.name}].sys.tables tab ON tab.object_id = col.object_id                                 
								INNER JOIN [{VarLib.Var.objDatabaseSelected.name}].sys.types ty ON ty.user_type_id = col.system_type_id
                                WHERE col.object_id = { VarLib.Var.objTablesSelected.object_id}";
  
            return ConvertTypesToCSharp(GetList<ColumnsModels>(cmd));
        }   

        public List<ColumnsModels> ConvertTypesToCSharp(List<ColumnsModels> obj)
        {

            foreach (ColumnsModels rw in obj)
            {
                switch (rw.TypeName)
                {
                    case "bigint":
                    case "bit":
                    case "smallint":
                    case "int":
                    case "tinyint":
                        rw.TypeNameConvert = "Int32";
                        rw.HTML_Mask = ".m_numero";
                        rw.HTML_Type = "Number";
                        break;

                    case "numeric":
                    case "decimal":
                    case "smallmoney":
                    case "money":
                    case "float":
                    case "real":
                        rw.TypeNameConvert = "double";
                        rw.HTML_Mask = ".msk_decimal";
                        rw.HTML_Type = "Number";
                        break;
                    case "date":
                    case "datetime2":
                    case "smalldatetime":
                    case "datetime":
                    case "time":
                        rw.TypeNameConvert = "DateTime";
                        rw.HTML_Mask = ".msk_date";
                        rw.HTML_Type = "date";
                        break;

                    case "uniqueidentifier":
                    case "char":
                    case "varchar":
                    case "text":
                    case "nchar":
                    case "nvarchar":
                    case "ntext":
                    case "binary":
                    case "varbinary":
                        rw.TypeNameConvert = "string";
                        rw.HTML_Mask = ".msk_text";
                        rw.HTML_Type = "Text";
                        break;
                    case "imagem":
                        rw.TypeNameConvert = "image";
                        rw.HTML_Type = "img";
                        break;
                }

                if (rw.ColumnOwner.Equals(""))
                {
                    rw.ColumnOwner = rw.name.ToString();
                    rw.HTML_Id= rw.name.ToString();
                }
            }
            return obj;
        }
    }
}

