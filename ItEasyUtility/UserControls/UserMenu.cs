using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItEasyUtility.Models;

namespace ItEasyUtility.UserControls
{
    public partial class UserMenu : UserControl
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        public Form ActiveForm
        {
            set
            {

                if (Var.itEasyFrm != null)
                {
                    if (!Var.itEasyFrm.Text.ToString().Equals("ItEasyTools"))
                    {
                        EnableMenuItem();                    
                        Var.itEasyFrm = null;
                    }
                }
                if (value != null)
                {
                    Var.itEasyFrm = value;
                }
            }
            get
            {
                return Var.itEasyFrm;
            }

        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Var.itEasyFrm.Text.ToString().Equals("ItEasyTools"))
            {
                ItEasyMenu.Items[0].Enabled = false;
                ItEasyTools frm = new ItEasyTools();

                frm.ShowDialog();
            }
        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItEasyMenu.Items[1].Enabled = false;
            pesquisacolumns frm = new pesquisacolumns();
            ActiveForm = frm;
            frm.ShowDialog();
        }
        void EnableMenuItem()
        {
foreach(ToolStripMenuItem it in ItEasyMenu.Items)
            {
                it.Enabled = true;
            }

        }
    }
}
