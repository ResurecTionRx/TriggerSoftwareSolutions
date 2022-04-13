using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerSoftwareSolutions.CLIENTS;
using TriggerSoftwareSolutions.ENTITY.Parametros;
using TriggerSoftwareSolutions.ENTITY.Response;

namespace TriggerSoftwareSolutions.BUSINESS
{
    public class BUPais
    {
        private Client client;

        public BUPais()
        {
            client = new Client();
        }

        public List<ResponsePais> listaPaises(ENRegistroEmpresa paramss,string token) 
        {
            try
            {
                return JsonConvert.DeserializeObject<List<ResponsePais>>(client.Post<ENRegistroEmpresa>("RegistroEmpresa/listarPaises", paramss, token));
            }
            catch (Exception ex) {
                throw;
            }
        }
    }
}
