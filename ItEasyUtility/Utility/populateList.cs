using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItEasyUtility.Models;
using ItEasyUtility.Controllers;
using ItEasyUtility.Repository.Repository;

namespace ItEasyUtility.Utility
{
    public class populateList : RepositoryBase
    {
        private VarComboModels VarCombo = new VarComboModels();
        public void cboTables_List(ListBox lst)
        {
            TablesControllers ObjControllers = new TablesControllers();
            Var.objListTables = ObjControllers.GetList().ToList();
            lst.ValueMember = "object_id";
            lst.DisplayMember = "name";
            lst.DataSource = Var.objListTables;
            lst.SelectedIndex = -1;
        }
        public void cboTablesCombos_List(ComboBox lst)
        {
            TablesControllers ObjControllers = new TablesControllers();
            Var.objListTables = ObjControllers.GetList().ToList();
            Var.objListTables.Insert(0, new TablesModels { name = "Todas as Tabelas", object_id = 0 });
            lst.ValueMember = "object_id";
            lst.DisplayMember = "name";            
            lst.DataSource = Var.objListTables;
            lst.SelectedIndex = 0;
        }

        public void cboColumns_List(ListBox lst, Int16 object_id)
        {
            //string cmd = $@"SELECT name as DisplayMember, column_id as ValueMember  FROM sys.Columns WHERE object_id = {object_id} ORDER BY column_id";
            ColumnsControllers ObjControllers = new ColumnsControllers();
            Var.objListColumns = ObjControllers.GetList().ToList();
            lst.ValueMember = "column_id";
            lst.DisplayMember = "name";
            //List<VarComboModels> x = GetList<VarComboModels>(cmd);
            lst.DataSource = Var.objListColumns; // GetList<VarComboModels>(cmd);
            lst.SelectedIndex = -1;
        }
        public void cboDatabases_List(ListBox lst)

        {
            DataBaseControllers ObjControllers = new DataBaseControllers();
            Var.objListDatabases = ObjControllers.GetListView();
            lst.ValueMember = "database_id";
            lst.DisplayMember = "name";
            lst.DataSource = Var.objListDatabases;
            lst.SelectedIndex = -1;
        }
        public void cboDatabasesCombo_List(ComboBox lst)

        {
            DataBaseControllers ObjControllers = new DataBaseControllers();
            Var.objListDatabases = ObjControllers.GetListView();
            Var.objListDatabases.Insert(0, new DataBaseModels { name = "Selecionar", database_id = "0" });
            lst.ValueMember = "database_id";
            lst.DisplayMember = "name";
            lst.DataSource = Var.objListDatabases;
            lst.SelectedIndex = 0;
        }

        public void cboConexaos_List(ComboBox lst)

        {
            ConexaoCotrollers conexaoCotrollers = new ConexaoCotrollers();
            lst.ValueMember = "StringConexao";
            lst.DisplayMember = "NomeConexao";
            lst.DataSource = Var.objListConexao;
            lst.SelectedIndex = 0;
        }


        public void cboVariables_List(ComboBox lst)
        {
            lst.Items.Add("");
            lst.Items.Add("double");
            lst.Items.Add("DateTime");
            lst.Items.Add("string");
            lst.Items.Add("image");
            lst.SelectedIndex = 0;

        }
    }
}
