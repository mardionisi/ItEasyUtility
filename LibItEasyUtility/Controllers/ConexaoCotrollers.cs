using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;

namespace LibItEasyUtility.Controllers
{
    public class ConexaoCotrollers
    {
        public List<ConexaoModels> CargaVariable()
        {             

            List<ConexaoModels> itemList = new List<ConexaoModels>();
            ConexaoModels item = new ConexaoModels();
            item.NomeConexao = "Selecionar";
            item.StringConexao = "-1";
            itemList.Add(item);

            item = new ConexaoModels();
            item.NomeConexao = "Home";
            item.StringConexao = @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename = D:\TeamDionisi\Contabil\iteasycontabil\ItEasyContabil\BancoDados\iTContabil.mdf; Integrated Security = True";
            itemList.Add(item);

            item = new ConexaoModels(); 
            item.NomeConexao = "WebMotors";
            item.StringConexao = @"Data Source = 168.61.156.165; Initial Catalog = PitstopWeb; User ID = pitstopweb; Password = gsit@97531; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            itemList.Add(item);
            return itemList;
        }
    }
}
