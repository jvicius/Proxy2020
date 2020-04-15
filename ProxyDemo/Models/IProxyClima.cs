namespace ProxyDemo.Models
{
    public interface IProxyClima
    {
        Clima ObtenerClimaActual(string ciudad);

        Pronostico ObtenerPronostico(string ciudad);
    }
}