using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibItEasyUtility.Auxuliar
{
    public static class auxiliares
    {
        public static void cboVariables_List(ComboBox lst)
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
