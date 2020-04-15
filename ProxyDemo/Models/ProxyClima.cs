using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDemo.Models
{
    public class ProxyClima : IProxyClima
    {
        private RestClient _client;
        private string _key = "b1e34d4d55487b41db609a28e5854900";
        private string _metrica = "metric";
        private string _urlBase = "http://api.openweathermap.org/data/2.5/";

        public ProxyClima()
        {
            _client = new RestClient(_urlBase);
        }
        public Clima ObtenerClimaActual(string ciudad)
        {
            var request = new RestRequest($"weather?q={ciudad}&APPID={_key}&units={_metrica}");
            var response = _client.Get<Clima>(request);
            return response.Data;
        }

        public Pronostico ObtenerPronostico(string ciudad)
        {
            var request = new RestRequest($"forecast?q={ciudad}&APPID={_key}&units={_metrica}");
            var response = _client.Get<Pronostico>(request);
            return response.Data;
        }
    }
}
