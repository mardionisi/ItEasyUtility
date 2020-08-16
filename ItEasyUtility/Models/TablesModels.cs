using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Repository.Interface;
using System.ComponentModel;

namespace ItEasyUtility.Models
{
    public class TablesModels 
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        public string name { set; get; }
        public Int32 object_id { set; get; }
        public Int32 principal_id { set; get; }
        public Int32 schema_id { set; get; }
        public Int32 parent_object_id { set; get; }
        public string type { set; get; }
        public string type_desc { set; get; }
        public DateTime create_date { set; get; }
        public DateTime modify_date { set; get; }
        public Int32 is_ms_shipped { set; get; }
        public Int32 is_published { set; get; }
        public Int32 is_schema_published { set; get; }
        public Int32 lob_data_space_id { set; get; }
        public Int32 filestream_data_space_id { set; get; }
        public Int32 max_column_id_used { set; get; }
        public Int32 lock_on_bulk_load { set; get; }
        public Int32 uses_ansi_nulls { set; get; }
        public Int32 is_replicated { set; get; }
        public Int32 has_replication_filter { set; get; }
        public Int32 is_merge_published { set; get; }
        public Int32 is_sync_tran_subscribed { set; get; }
        public Int32 has_unchecked_assembly_data { set; get; }
        public Int32 text_in_row_limit { set; get; }
        public Int32 large_value_types_out_of_row { set; get; }
        public Int32 is_tracked_by_cdc { set; get; }
        public Int32 lock_escalation { set; get; }
        public string lock_escalation_desc { set; get; }
        public Int32 is_filetable { set; get; }
        public Int32 is_memory_optimized { set; get; }
        public Int32 durability { set; get; }
        public string durability_desc { set; get; }
        public Int32 temporal_type { set; get; }
        public string temporal_type_desc { set; get; }
        public Int32 history_table_id { set; get; }
        public Int32 is_remote_data_archive_enabled { set; get; }
        public Int32 is_external { set; get; }

    }
}
