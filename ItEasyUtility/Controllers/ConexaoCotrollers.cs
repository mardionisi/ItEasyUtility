using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Models;

namespace ItEasyUtility.Controllers
{
    public class ConexaoCotrollers
    {
        public ConexaoCotrollers()
        {
            cargaString();

        } 

        void cargaString()
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
            item.NomeConexao = "Capta";
            item.StringConexao = @"Data Source = 192.168.30.21,1054; Initial Catalog = CA_ERP; User ID = captasup; Password = siscons; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            itemList.Add(item);
            Var.objListConexao = itemList;
        }    
                    
    }  

}

