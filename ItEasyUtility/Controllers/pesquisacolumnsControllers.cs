using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItEasyUtility.Models;
using ItEasyUtility.Repository.Repository;

namespace ItEasyUtility.Controllers
{
    public class pesquisacolumnsControllers : RepositoryBase
    {
        public List<pesquisacolumnsModels> GetList()
        {
            string cmd = $@"SELECT ta.name as TbName, co.Name, ty.name as VrName,ty.max_length FROM {Var.objDataBaseSelected}.sys.Columns co 
                                INNER JOIN  {Var.objDataBaseSelected}.sys.Tables ta ON ta.object_id = co.object_id
                                INNER JOIN {Var.objDataBaseSelected }.sys.types ty ON ty.user_type_id = co.user_type_id
                                WHERE co.Name like '%{Var.objFieldSelected }%'";
            List<pesquisacolumnsModels> x = GetList<pesquisacolumnsModels>(cmd);
            Contagem(x);
            return x;
        }
        void Contagem(List<pesquisacolumnsModels> sobjList)
        {
            string cmd = "";
            //string field = Var.objFieldSelected;
            //string valor = Var.objValorSelected;
            //List<string> rs = new List<string>();
             Int32 Num = 0;
              foreach(pesquisacolumnsModels rw in sobjList) {
                cmd = $@"SELECT Count({rw.Name}) FROM {Var.objDataBaseSelected}.dbo.{rw.TbName} ";
                if(!Var.objValorSelected.ToString().Equals(Var.objValorSelected)){
                    cmd += $@" WHERE Convert(vanchar(100),{rw.Name}) = '{Var.objValorSelected}'";
                }  
                
                List<string> x= GetList<string>(cmd);
                Int32.TryParse(x[0].ToString(), out Num);
                rw.NumReg = Num;

              }

        }
    }
}
