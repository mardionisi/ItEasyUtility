using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItEasyUtility.Models;
using ItEasyUtility.ViewModel;
using ItEasyUtility.Utility;
using ItEasyUtility.Controllers;
using ItAdoConn.Models;

namespace ItEasyUtility
{
    public partial class pesquisacolumns : Form
    {
        private populateList cbList = new populateList();
        private pesquisacolumnsControllers pesqControl = new pesquisacolumnsControllers();
        private List<pesquisacolumnsModels> sObjSearch = new List<pesquisacolumnsModels>();
        public object ItEasyUtilityÌontrolUserBasic { get; private set; }

        public pesquisacolumns()
        {
            InitializeComponent();
        }

        private void pesquisacolumns_Load(object sender, EventArgs e)
        {
       
        userConn.cboConexao.SelectedIndexChanged += new System.EventHandler(userConn_userConn_Changed);
        }

        private void userConn_userConn_Changed(object sender, EventArgs e)
        {
            if (userConn.cboConexao.SelectedItem != null)
            {
                if (userConn.cboConexao.SelectedIndex>0)
                {
                    ItVarSqL.objConexaoSelected = userConn.cboConexao.SelectedValue.ToString();
                    userDatabase.Conexao = userConn.cboConexao.SelectedValue.ToString();
                }
                else
                {
                    userDatabase.Conexao = "";

                }
            }
            else
            {
                userDatabase.Conexao = "";

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pesquisacolumnsControllers cont = new pesquisacolumnsControllers();
            //Var.objListPesquisa
            Var.objDataBaseSelected = userDatabase.ListDatabase.Text;
           
            Var.objFieldSelected = txBuscaCampo.Text;
            Var.objValorSelected = txValor.Text;
        sObjSearch = cont.GetList();
            Var.objListPesquisa = sObjSearch;
            gwSearch.DataSource = sObjSearch;
        }
    }

    }
