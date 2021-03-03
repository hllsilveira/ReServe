using System;
using Xunit;
using TesteReServe.Data;
using TesteReServe.Models;
using System.Collections.Generic;

namespace ReServe.Teste
{
    public class TesteApi
    {
        [Fact]
        public void TestandoApi()
        {
            try
            {
                var api = new UsaApiCovid(new ApiCovidGetPostMan());
                List<CovidPais> dados = api.RankingCovid();

                if (dados.Count > 0)
                    Assert.True(true);
                else
                    Assert.False(false);
            }
            catch (Exception E)
            {
                Assert.False(false, E.Message);
            }
        }

    }
}
