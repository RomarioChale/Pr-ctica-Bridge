using Patrón_Bridge.Bridge;
using System;

namespace Patrón_Bridge.Servicios.Paqueterias
{
    public class Fedex : MetodoEnvios
    {
        public Fedex(IMensajeria mensajeria) : base(mensajeria)
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
