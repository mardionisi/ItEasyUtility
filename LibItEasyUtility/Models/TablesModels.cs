using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibItEasyUtility.Models
{
    public class TablesModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name { set; get; }
        public Int32 object_id { set; get; }

        private string _x = "";
        public string x {

            set{
                x = value;
                OnPropertyChanged("Teste");
            }
            get {
                return _x;
            }

        }
        protected void OnPropertyChanged( string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    
}
