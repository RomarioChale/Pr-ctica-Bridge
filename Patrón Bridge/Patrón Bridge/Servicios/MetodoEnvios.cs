using Patrón_Bridge.Bridge;

namespace Patrón_Bridge.Servicios
{
    public abstract class MetodoEnvios
    {
        protected Bridge.IMensajeria _mensajeria;
        public MetodoEnvios(Bridge.IMensajeria mensajeria)
        {
            _mensajeria = mensajeria;
        }

        public abstract void RecogerPedido();
        public abstract void EnviarPedido();
        public abstract void EntregarPedido();
        public abstract void Display(string text);
    }
}
