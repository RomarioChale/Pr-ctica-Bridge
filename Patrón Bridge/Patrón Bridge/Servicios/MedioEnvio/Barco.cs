using Patrón_Bridge.Bridge;
using System;

namespace Patrón_Bridge.Servicios.MedioEnvio
{
    public class Barco : IMensajeria
    {
        public void Display(string text)
        {
            Console.WriteLine(text + " " +"Envío por barco");
        }

        public void EntregarPedido()
        {
            throw new NotImplementedException();
        }

        public void EnviarPedido()
        {
            throw new NotImplementedException();
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Envio por barco");

        }
    }
}
