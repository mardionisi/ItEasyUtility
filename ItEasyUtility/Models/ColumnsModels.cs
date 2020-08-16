using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Repository.Repository;
using ItEasyUtility.Models;

namespace ItEasyUtility.Models
{
    public class ColumnsModels
    {
        public Int32 object_id { set; get; }
        public string tableName { set; get; }
        public string TypeName { set; get; }
        public string TypeNameConvert { set; get; }
        public string ColumnOwner { set; get; }
        public string name { set; get; }
        public Int32 column_id { set; get; }
        public Int32 system_type_id { set; get; }
        public Int32 user_type_id { set; get; }
        public Int32 max_length { set; get; }
        public Int32 precision { set; get; }
        public Int32 scale { set; get; }
        public string collation_name { set; get; }
        //public Int32 is_nullable { set; get; }
        //public Int32 is_ansi_padded { set; get; }
        //public Int32 is_rowguidcol { set; get; }
        //public Int32 is_identity { set; get; }
        //public Int32 is_computed { set; get; }
        //public Int32 is_filestream { set; get; }
        //public Int32 is_replicated { set; get; }
        //public Int32 is_non_sql_subscribed { set; get; }
        //public Int32 is_merge_published { set; get; }
        //public Int32 is_dts_replicated { set; get; }
        //public Int32 is_xml_document { set; get; }
        //public Int32 xml_collection_id { set; get; }
        //public Int32 default_object_id { set; get; }
        //public Int32 rule_object_id { set; get; }
        //public Int32 is_sparse { set; get; }
        //public Int32 is_column_set { set; get; }
        //public Int32 generated_always_type { set; get; }
        //public string generated_always_type_desc { set; get; }
        //public Int32 encryption_type { set; get; }
        //public string encryption_type_desc { set; get; }
        //public string encryption_algorithm_name { set; get; }
        //public Int32 column_encryption_key_id { set; get; }
        //public string column_encryption_key_database_name { set; get; }
        //public Int32 is_hidden { set; get; }
        //public Int32 is_masked { set; get; }

    }
}
