using ProxyDemo.Models;
using System;
using System.Linq;

namespace ProxyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyClima();
            var response = proxy.ObtenerClimaActual("rome");

            Console.WriteLine($"ciudad:{response.name}");
            Console.WriteLine($"temperatura:{response.main.temp}");
            Console.WriteLine($"min:{response.main.temp_min}");
            Console.WriteLine($"max:{response.main.temp_max}");

            var response2 = proxy.ObtenerPronostico("rome");

            Console.WriteLine("");
            Console.WriteLine($"ciudad:{response2.city.name}");

            foreach(var clima in response2.list.Take(5))
            {
                Console.WriteLine($"temperatura:{clima.main.temp}");
                Console.WriteLine($"min:{clima.main.temp_min}");
                Console.WriteLine($"max:{clima.main.temp_max}");
            }

        }
    }
}
