using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Repository.Repository;
using ItEasyUtility.Models;


namespace ItEasyUtility.Controllers
{
    public class TablesControllers : RepositoryBase
    {
        public List<TablesModels> GetList(){
            string cmd = string.Format(@"SELECT name, object_id, principal_id, schema_id, parent_object_id, type, type_desc, create_date, modify_date, is_ms_shipped, is_published, is_schema_published, lob_data_space_id, filestream_data_space_id, max_column_id_used, lock_on_bulk_load, uses_ansi_nulls, is_replicated, has_replication_filter, is_merge_published, is_sync_tran_subscribed, has_unchecked_assembly_data, text_in_row_limit, large_value_types_out_of_row, is_tracked_by_cdc, lock_escalation, lock_escalation_desc, is_filetable, is_memory_optimized, durability, durability_desc, temporal_type, temporal_type_desc, history_table_id, is_remote_data_archive_enabled, is_external FROM {0}.sys.Tables ORDER BY name",Var.objSelectDataBase.name);
            return GetList<TablesModels>(cmd);
        }    
    public List<TablesModels> GetListView()
    {
        string cmd = string.Format(@"SELECT name, object_id FROM {0}.sys.Tables WHERE Type='U' ORDER BY name",Var.objSelectDataBase);
        return GetList<TablesModels>(cmd);
    } 
    }
}
