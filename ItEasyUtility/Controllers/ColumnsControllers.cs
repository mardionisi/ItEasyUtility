using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Repository.Repository;
using ItEasyUtility.Models;

namespace ItEasyUtility.Controllers
{
    public class ColumnsControllers : RepositoryBase
    {

        public List<ColumnsModels> GetList()
        {
            string cmd = $@"SELECT  ty.name as TypeName,
                                tab.name as TableName, col.object_id, col.name, col.column_id, col.system_type_id, col.user_type_id, col.max_length, col.precision, 
                                col.scale, col.collation_name, col.is_nullable, col.is_ansi_padded, col.is_rowguidcol, col.is_identity, col.is_computed, 
                                col.is_filestream, col.is_replicated, col.is_non_sql_subscribed, col.is_merge_published, col.is_dts_replicated, col.is_xml_document, 
                                col.xml_collection_id, col.default_object_id, col.rule_object_id, col.is_sparse, col.is_column_set, 
                                col.generated_always_type, col.generated_always_type_desc, col.encryption_type,col.encryption_type_desc, 
                                col.encryption_algorithm_name, col.column_encryption_key_id, col.column_encryption_key_database_name, 
                                col.is_hidden, col.is_masked,'' as columnOwner
                                FROM sys.columns col
                                INNER JOIN sys.tables tab ON tab.object_id = col.object_id                                 
								INNER JOIN sys.types ty ON ty.user_type_id = col.system_type_id
                                WHERE col.object_id = { Var.objSelectTable.object_id}";

            return ConvertTypesToCSharp(GetList<ColumnsModels>(cmd));
        }
        public List<TablesModels> GetListView()
        {
            string cmd = "SELECT name, object_id FROM sys.Tables ORDER BY name";
            return GetList<TablesModels>(cmd);
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
                      rw.TypeNameConvert =  "Int32";
break;

                    case "numeric":
                    case "decimal":
                    case "smallmoney":
                    case "money":
                    case "float":
                    case "real":
                        rw.TypeNameConvert = "double";
                        break;
                    case "date":
                    case "datetime2":
                    case "smalldatetime":
                    case "datetime":
                    case "time":
                        rw.TypeNameConvert = "DateTime";
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
                        break;
                    case "imagem":
                        rw.TypeNameConvert = "image";
                        break;
                }

               if(rw.ColumnOwner.Equals(""))  {
                    rw.ColumnOwner = rw.name.ToString();
               }
            }
            return obj;
        }
    }
}
