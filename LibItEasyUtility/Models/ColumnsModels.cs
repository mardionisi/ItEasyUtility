using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibItEasyUtility.Models
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
        public Int32 is_nullable { set; get; }

        public string HTML_Type { set; get; }
        public string HTML_input { set; get; }
        public string HTML_Mask { set; get; }
        public string HTML_Id { set; get; }
    }
}
