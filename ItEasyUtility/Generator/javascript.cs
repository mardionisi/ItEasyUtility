using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibItEasyUtility.Models;

namespace ItEasyUtility.Generator
{
    public class javascript
    {
        public string criarjavascript(List<ColumnsModels> lst, string table, string mynamespace)
        {
            StringBuilder sb = new StringBuilder();
            string comentario = @"/*********************************************************************************************************************************************************";
            string concat = "";
            Int32 ordem = 0;

            //Populate Variable

            sb.Append(comentario + "\r\n");
            sb.Append(@"/ *Populate Variable" + "\r\n");
            sb.Append(comentario + "/ \r\n");
            sb.Append("populateVariable = function() { \r\n");
            sb.Append("var fields = { \r\n");

            lst.ForEach(delegate (ColumnsModels col)
            {
                concat += string.Format("'{0}': $('#{0}').val(),\r\n", col.ColumnOwner.ToString().Trim());
            });
            concat = concat.Substring(0, concat.Length - 3);
            sb.Append(concat);
            sb.Append("\r\n }; \r\n");
            sb.Append("return fields }; \r\n");

            //Populate TextBox
            concat = "";
            sb.Append("\r\n");
            sb.Append(comentario + "\r\n");
            sb.Append(@"/ *Populate TextBox" + "\r\n");
            sb.Append(comentario + "/ \r\n");
            sb.Append("populateTextBox = function(fields) { \r\n");

            lst.ForEach(delegate (ColumnsModels col)
            {
                concat += string.Format("$('#{0}').val(fields.{0})\r\n", col.ColumnOwner.ToString().Trim());
            });
            sb.Append(concat);
            sb.Append("\r\n }; \r\n");



            // CleanTextBox
            concat = "";
            sb.Append(comentario + "\r\n");
            sb.Append(@"/ *Clean Elements" + "\r\n");
            sb.Append(comentario + "/ \r\n");
            sb.Append("cleanElement = function() { \r\n");
            lst.ForEach(delegate (ColumnsModels col)
            {
                concat += string.Format("$('#{0}').val('')\r\n", col.ColumnOwner.ToString().Trim());
            });
            sb.Append(concat);
            sb.Append("\r\n }; \r\n");


            // Validando Iformações
            concat = "";
            sb.Append(comentario + "\r\n");
            sb.Append(@"/ *Validando Informações" + "\r\n");
            sb.Append(comentario + "/ \r\n");
            sb.Append("var msg =''; \r\n");
            sb.Append("validando = function() { \r\n");
            lst.ForEach(delegate (ColumnsModels col)
            {
                sb.Append("if ($('#" + col.ColumnOwner.ToString().Trim() +"').val().replace(/\\ /g, '').length === 0) { \r\n");
                sb.Append(@"   msg += '\n\n\<seu comentário>';"  + "\r\n }\r\n");
            });
            sb.Append("\r\n }; \r\n");

            return sb.ToString();
        }

    }
}

