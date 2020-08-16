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
using LibItEasyUtility.Models;
using LibItEasyUtility.VarLib;

namespace LibItEasyUtility.UserControls
{ 
public partial class UserBancoDados : UserControl
{
    private string _conexao;
    public string Conexao
        {
            set
            {
                _conexao = value;
                if (_conexao != null)
                {
                    carregarDataBase();
                }
            }
            get
            {
                return _conexao;

            }
        }
        public UserBancoDados()
    {
        InitializeComponent();
    }
        private List<DataBasesModels> sLstDatabases = new List<DataBasesModels>();
        void carregarDataBase(){
         
            ListDatabase.DisplayMember = "name";
            ListDatabase.ValueMember = "database_id";
            sLstDatabases = Var.objListDatabases;
            sLstDatabases.Insert(0, new DataBasesModels
            {
                database_id = "-1",
                name = "Selecionar ..."

            });
            ListDatabase.DataSource = sLstDatabases;
            ListDatabase.SelectedIndex = 0;


        }

        private void tDatabase_TextChanged(object sender, EventArgs e)
        {
            ListDatabase.DataSource = sLstDatabases.Where(p => p.name.ToString().ToUpper().Contains(fDataBase.Text.ToString().ToUpper().Trim())).ToList();

        }
    }
}
