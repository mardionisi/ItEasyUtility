using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibItEasyUtility.VarLib;

namespace LibItEasyUtility.UserControls
{
    public partial class UserConexao : UserControl
    {
        public UserConexao()
        {
            InitializeComponent();
        }

        private Int32 _conexaotextId=0;
        private string _conexaotext;
        public string ConexaoText
        {
            set
            {
                _conexaotext = value;
                CarregarConexoes();
                cboConexao.Text = _conexaotext;
                _conexaotextId = cboConexao.SelectedIndex;
            }

        }
        private void UserConexao_Load(object sender, EventArgs e)
        {
            CarregarConexoes();
            if (_conexaotextId > 0)
            {
                cboConexao.SelectedIndex = _conexaotextId;
            }
        }
        void CarregarConexoes()
        {

            cboConexao.DataSource = VarLib.Var.objListConexao;
        }

        private void cboConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConexao.SelectedIndex > 0)
            {
                Var.objConexaoSelected = cboConexao.SelectedValue.ToString();
            }
        }
    }
}
