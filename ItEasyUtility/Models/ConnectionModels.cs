using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItEasyUtility.Models
{
    public class ConnectionModels
    {
        public int Id { get; set; }
        public Guid IdGuid { set; get; }
        public string nomeConexao { get; set; }
        public string BancoDadosConexao { get; set; }
        public string strConexao { get; set; }
        public DateTime Atualizado { set; get; }
    }
}
