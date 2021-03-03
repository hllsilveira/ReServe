using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteReServe.Models
{
    public class Countries
    {

        public string ID { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public double NewConfirmed { get; set; }
        public double TotalConfirmed { get; set; }
        public double NewDeaths { get; set; }
        public double TotalDeaths { get; set; }
        public double NewRecovered { get; set; }
        public double TotalRecovered { get; set; }
        public string Date { get; set; }
        public string Premium { get; set; }
    }

    public class CovidPais
    {
        public string Country { get; set; }
        public double TotalConfirmed { get; set; }
        public double TotalRecovered { get; set; }

    }
}
