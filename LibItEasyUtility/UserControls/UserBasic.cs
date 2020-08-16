using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibItEasyUtility.Controllers;
using ItAdoConn.Models;
using LibItEasyUtility.Models;


namespace LibItEasyUtility.UserControls
{
    public partial class UserBasic : UserControl
    {
        private TextBox _TxTobject_id;
        public TextBox TxTobject_id
        {
            set
            {
                if (value !=null)
                {
                    _TxTobject_id.Text = value.Text;
                }
            }
            get
            {
                return _TxTobject_id;
            }
        }
        private Int32 _Tablesobject_id;
        public Int32 Tablesobject_id
        {
            set
            {
                _Tablesobject_id = value;
            }
            get
            {
                return _Tablesobject_id;
            }
        }
       
        public UserBasic()
        {
            InitializeComponent();
        }
        private List<DataBasesModels> sLstDatabases = new List<DataBasesModels>();
        private List<TablesModels> sLstTables = new List<TablesModels>();
        private void UserBasic_Load(object sender, EventArgs e)
        {
            CarregarConexoes();
        }
        void CarregarConexoes()
        {

            cboConexao.DataSource = VarLib.Var.objListConexao;
        }

        private void cboConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cboConexao.SelectedValue.ToString().Equals("-1"))
                {

                    ItVarSqL.objConexaoSelected = cboConexao.SelectedValue.ToString();
                    LstDatabase.DisplayMember = "name";
                    LstDatabase.ValueMember = "database_id";
                    sLstDatabases = VarLib.Var.objListDatabases;
                    sLstDatabases.Insert(0, new DataBasesModels
                    {
                        database_id = "-1",
                        name = "Selecionar ..."

                    });
                    LstDatabase.DataSource = sLstDatabases;
                    LstDatabase.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), VarLib.Var.LibCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void fDataBase_TextChanged(object sender, EventArgs e)
        {

            LstDatabase.DataSource = sLstDatabases.Where(p => p.name.ToString().ToUpper().Contains(fDataBase.Text.ToString().ToUpper().Trim())).ToList();
            fTable.Text = "";
            CleancboTables();
            LstDatabase.ClearSelected();
        }

        private void LstDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstDatabase.SelectedItem != null)
            {
                if (((DataBasesModels)LstDatabase.SelectedItem).database_id != "-1")
                {
                    VarLib.Var.objDatabaseSelected = LstDatabase.SelectedItem as DataBasesModels;
                    sLstTables = VarLib.Var.objListTables;
                    sLstTables.Insert(0, new TablesModels
                    {
                        object_id = -1,
                        name = "Selecionar ..."

                    });
                    LstTables.DisplayMember = "name";
                    LstTables.ValueMember = "object_id";
                    LstTables.DataSource = sLstTables;
                    LstTables.SelectedIndex = 0;
                }
                else
                {
                    VarLib.Var.objDatabaseSelected = null;
                    CleancboTables();
                }
            }
        }

        void CleancboDataBase()
        {
            sLstDatabases = new List<DataBasesModels>();
            LstDatabase.DataSource = null;
            fTable.Text = "";

        }

        void CleancboTables()
        {
            sLstTables = new List<TablesModels>();
            LstTables.DataSource = null;
            fTable.Text = "";

        }
        private void LstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstTables.SelectedItem != null)
            {
                if (((TablesModels)LstTables.SelectedItem).object_id != -1)
                {

                    VarLib.Var.objTablesSelected = (TablesModels)LstTables.SelectedItem;
                }
                else
                {
                    VarLib.Var.objTablesSelected = null;
                }
            }
        }

        private void fTable_TextChanged(object sender, EventArgs e)
        {
            LstTables.DataSource = sLstTables.Where(p => p.name.ToUpper().Contains(fTable.Text.ToString().ToUpper().Trim())).ToList();
            LstTables.ClearSelected();
        }
    }
}
