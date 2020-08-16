using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItAdoConn.Models;
using LibItEasyUtility.Controllers;
using LibItEasyUtility.Models;
using LibItEasyUtility.Auxuliar;

namespace LibItEasyUtility.UserControls
{
    public partial class UserColumns : UserControl
    {
        string tVariavelOld = "";
        string cboConvertTypeOld = "";
        public Int32 ColumnsobjectId {
        set {
                if (value != -1)
                {
                    populategwColumns();
                } else
                {

                    ClearFields();
                }
        }

        }
        public List<ColumnsModels> sListColumns = new List<ColumnsModels>();
        public UserColumns()
        {
            InitializeComponent();
        }
     
        private void UserColumns_Load(object sender, EventArgs e)
        {
            gwColumns.AutoGenerateColumns = false;
            auxiliares.cboVariables_List(cboConvertType);
        }

        void populategwColumns(){
            ColumnsControllers col = new ColumnsControllers();
           
            sListColumns = VarLib.Var.objListColumns.ToList();
            gwColumns.DataSource = sListColumns;
            gwColumns.ClearSelection();
        }

        private void fColumn_TextChanged(object sender, EventArgs e)
        {
            gwColumns.DataSource = sListColumns.Where(p=>p.name.ToString().ToUpper().Contains(fColumn.Text.ToString().ToUpper().Trim())).ToList();
            gwColumns.ClearSelection();
        }
        void ClearFields() {
            fColumn.Text = "";
            sListColumns = new List<ColumnsModels>();
            gwColumns.DataSource = sListColumns;
            cleanTextBox();
        }
        void cleanTextBox()
        {
            tNome.Text = "";
            tOrdem.Text = "";
            tTipo.Text = "";
            tTamanho.Text = "";
            tVariavel.Text = "";
            cboConvertType.Text = "";
            cboConvertTypeOld = "";
            tVariavelOld = "";
        }

        Int32 IndexAtivo = 0;
        ColumnsModels rw = new ColumnsModels();
        private void gwColumns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexAtivo = gwColumns.CurrentRow.Index;
            rw = gwColumns.Rows[gwColumns.CurrentRow.Index].DataBoundItem as ColumnsModels;
            tNome.Text = rw.name;
            tOrdem.Text = rw.column_id.ToString();
            tTipo.Text = rw.TypeName.ToString();
            tTamanho.Text = rw.max_length.ToString();
            tVariavel.Text = rw.ColumnOwner;
            cboConvertType.Text = rw.TypeNameConvert;
            cboConvertTypeOld = cboConvertType.Text;
            tVariavelOld = cboConvertType.Text;
        }

        private void tVariavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                tVariavel.Text = tVariavelOld;
            }
        }

        private void tVariavel_Leave(object sender, EventArgs e)
        {
            if (!tVariavel.Text.ToString().Equals(tVariavelOld) && !string.IsNullOrWhiteSpace(tVariavel.Text))
            {
                gwColumns.Rows[gwColumns.CurrentRow.Index].Cells[5].Value = tVariavel.Text.ToString().Trim();
                MessageBox.Show("Alterado");
            }

        }
        private void cboConvertType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConvertType.SelectedIndex > 0)
            {
                if (!cboConvertType.Text.ToString().Equals(tVariavelOld) && !string.IsNullOrWhiteSpace(cboConvertTypeOld))
                {
                    gwColumns.Rows[gwColumns.CurrentRow.Index].Cells[4].Value = cboConvertType.Text.ToString().Trim();
                }
            }
        }

        private void cboConvertType_Leave(object sender, EventArgs e)
        {
            if (!cboConvertType.Text.ToString().Equals(tVariavelOld) && !string.IsNullOrWhiteSpace(cboConvertTypeOld))
            {
                gwColumns.Rows[gwColumns.CurrentRow.Index].Cells[4].Value = cboConvertType.Text.ToString().Trim();
                MessageBox.Show("Alterado");
            }

        }
    }
}
