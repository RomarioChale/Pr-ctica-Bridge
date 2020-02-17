using System;
using Patrón_Bridge.Bridge;

namespace Patrón_Bridge.Servicios.Paqueterias
{
    public class Estafeta : MetodoEnvios
    {
        public Estafeta(IMensajeria mensajeria) : base(mensajeria)
        {
        }

        public override void Display(string text)
        {
            _mensajeria.Display(text);
        }

        public override void EntregarPedido()
        {
            throw new NotImplementedException();
        }

        public override void EnviarPedido()
        {
            throw new NotImplementedException();
        }

        public override void RecogerPedido()
        {
            throw new NotImplementedException();
        }
    }
}
