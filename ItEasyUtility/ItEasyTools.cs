using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibItEasyUtility.Models;
using ItEasyUtility.Generator;
using LibItEasyUtility.VarLib;

namespace ItEasyUtility
{
    public partial class ItEasyTools : Form
    {
        public ItEasyTools()
        {
            InitializeComponent();
            ItEasyUtility.Models.Var.itEasyFrm = this;
        }


        private void ItEasyTools_Load(object sender, EventArgs e)
        {
            userSearch.LstTables.SelectedIndexChanged += new System.EventHandler(userSearch_LstTables_Changed);
        }

        private void userSearch_LstTables_Changed(object sender, EventArgs e)
        {
            if (userSearch.LstTables.SelectedItem != null)
            {
                if (((TablesModels)userSearch.LstTables.SelectedItem).object_id != -1)
                {
                    userCols.ColumnsobjectId = ((TablesModels)userSearch.LstTables.SelectedItem).object_id;
                }
                else
                {
                    userCols.ColumnsobjectId = -1;

                }
            }
            else
            {
                userCols.ColumnsobjectId = -1;

            }
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            pesquisacolumns frm = new pesquisacolumns();
            
            if (userSearch.cboConexao.SelectedIndex > 0)
            {
                frm.userConn.ConexaoText = userSearch.cboConexao.Text;
                frm.userDatabase.Conexao = userSearch.cboConexao.Text;
            }
            if (userSearch.cboConexao.SelectedIndex > 0 && userSearch.LstDatabase.SelectedIndex>0)
            {
                frm.userDatabase.ListDatabase.Text = userSearch.LstDatabase.Text;
            }
            frm.ShowDialog();
        }

        private void btn_propriedade_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow();
            setget st = new setget();
            st.gerarpropriedades(userCols.sListColumns.ToList());
            frm.txCabecario.Text = "Propriedades";
            frm.txScript.Text = st.gerarpropriedades(userCols.sListColumns.ToList()).ToString();
            frm.ShowDialog();

        }

        private void btn_parametros_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow();
            parameters pr = new parameters();
           // pr.criarparamentos(userCols.sListColumns);
            frm.txCabecario.Text = "Parametros";
            frm.txScript.Text = pr.criarparamentos(userCols.sListColumns.ToList()).ToString();
            frm.ShowDialog();

        }
        void teste()
        {
            
           

        }

        private void btn_crud_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow();
            crud pr = new crud();
            //pr.criarcrud(userCols.sListColumns);
            frm.txCabecario.Text = "Crud";
            frm.txScript.Text = pr.criarcrud(userCols.sListColumns.ToList(), userSearch.LstTables.Text.ToString(), txNamespace.Text).ToString();
            frm.ShowDialog();

        }

        private void btn_js_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow();
            javascript pr = new javascript();
            //pr.criarcrud(userCols.sListColumns);
            frm.txCabecario.Text = "Crud";
            frm.txScript.Text = pr.criarjavascript(userCols.sListColumns.ToList(), userSearch.LstTables.Text.ToString(), txNamespace.Text).ToString();
            frm.ShowDialog();

        }
    }
}
