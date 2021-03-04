using System.Collections.Generic;
using System.Linq;
using TesteReServe.Models;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace TesteReServe.Data
{
    public class UsaApiCovid
    {
        private readonly IApiCovid _apicovid;

        public UsaApiCovid(IApiCovid apicovid)
        {
            _apicovid = apicovid;
        }

        public IEnumerable<CovidPais> RankingCovid()
        {
            return _apicovid.RankingCovid();
        }
    }
        

    public interface IApiCovid
    {
        IEnumerable<CovidPais> RankingCovid();

    }

    
    public class ApiCovidGetPostMan : IApiCovid
    {
        public static List<CovidPais> dados = new List<CovidPais>();

        public IEnumerable<CovidPais> RankingCovid()
        {
            dados.Clear();

           ExecutarAsync();

            if (dados.Count > 0)
            {
                IEnumerable<CovidPais> query = dados.OrderByDescending(x => x.Ativos);

                return query.Take(10);
            }
            else
                return dados;
        }

        void ExecutarAsync()
        {
            using (var cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = cliente.GetAsync("https://api.covid19api.com/summary").Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result.ToString();

                    //deserializando obj json
                    var obj = JsonSerializer.Deserialize<Rootobject>(json);                  

                    //austando dados com dados ativos
                    dados.Clear(); int id = 1;
                    foreach (var item in obj.Countries)
                    {
                        CovidPais i = new CovidPais();
                        i.Id = id;
                        i.Country = item.Country;
                        i.Ativos = (item.TotalConfirmed - item.TotalRecovered);

                        if (i.Ativos < 0)
                            i.Ativos = 0;

                        dados.Add(i);
                        id++;
                    }

                }
            }
        }


    }

    

   
}
