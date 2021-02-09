using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

using System.Data;
using System.Collections.ObjectModel;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace SoftplanAPI2.Driven.Conexao
{
    public class ConexaoAPI1
    {

        const string _conexaoAPI = "http://host.docker.internal:3000/";
       
        public HttpResponseMessage ExecutarGET( string _url)
        {
            HttpResponseMessage responseMessage;

            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                using (var cliente = new HttpClient(clientHandler))
                {
              
                    responseMessage = cliente.GetAsync(_conexaoAPI + _url).Result;

                    if (!responseMessage.IsSuccessStatusCode)
                        throw new Exception("Erro retorno API:" + _conexaoAPI + _url);
                }

                return responseMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                responseMessage = null;
            }

        }
    }
}
