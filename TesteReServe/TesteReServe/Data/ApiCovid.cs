using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using TesteReServe.Models;

namespace TesteReServe.Data
{
    public class UsaApiCovid
    {
        private readonly IApiCovid _apicovid;

        public UsaApiCovid(IApiCovid apicovid)
        {
            _apicovid = apicovid;
        }

        public List<CovidPais> RankingCovid()
        {
            return _apicovid.RankingCovid();
        }
    }
        

    public interface IApiCovid
    {
        List<CovidPais> RankingCovid();

    }

    public class ApiCovidGetPostMan : IApiCovid
    {
        public List<CovidPais> RankingCovid()
        {
            var requisicaoWeb = WebRequest.CreateHttp("https://api.covid19api.com/summary");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "ReServe";

            List<Models.CovidPais> dados = new List<CovidPais>();

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                //obtendo json
                var post = JsonConvert.DeserializeObject <Models.Countries>(objResponse.ToString());                
            
                streamDados.Close();
                resposta.Close();
            }


            if (dados.Count > 0)
                return (List<Models.CovidPais>)dados.OrderByDescending(x => x.TotalConfirmed).Take(10);
            else
                return dados;
        }
    }
}
