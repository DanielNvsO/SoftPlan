using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftplanAPI2.Driven.Conexao;
using SoftplanAPI2.Model;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

using System.Data;
using System.Collections.ObjectModel;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SoftplanAPI2.Driven
{
    public class CalculoJuros
    {

        public decimal Calcular(JurosEntidade valores)
        {
            ConexaoAPI1 conexao;
            HttpResponseMessage msg;
            JurosEntidade retorno;
            JurosEntidade valorfinal;

            try
            {
               
                conexao = new ConexaoAPI1();

                msg = conexao.ExecutarGET("TaxaJuros/");
                retorno = JsonConvert.DeserializeObject<JurosEntidade>(msg.Content.ReadAsStringAsync().Result);

                valores.taxajuros = retorno.taxajuros;

                valorfinal = new JurosEntidade(valores);

                return valorfinal.valorFinal;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao = null;
                valorfinal = null;
                msg = null;
                retorno = null;
                
            }

            
        }
    }
}
