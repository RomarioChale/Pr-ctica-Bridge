using Patrón_Bridge.Bridge;
using System;

namespace Patrón_Bridge.Servicios.MedioEnvio
{
    public class Avion : IMensajeria
    {
        public void Display(string text)
        {
            Console.WriteLine(text + " " +"Envío por avión");
        }

        public void EntregarPedido()
        {
            throw new System.NotImplementedException();
        }

        public void EnviarPedido()
        {
            throw new System.NotImplementedException();
        }

        public void RecogerPedido()
        {
            throw new System.NotImplementedException();
        }
    }
}
