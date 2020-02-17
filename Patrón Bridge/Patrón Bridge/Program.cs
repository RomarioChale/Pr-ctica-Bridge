using Patrón_Bridge.Servicios;
using Patrón_Bridge.Servicios.MedioEnvio;
using Patrón_Bridge.Servicios.Paqueterias;
using System;

namespace Patrón_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoEnvios metodoFedex = new Fedex(new Barco());
            metodoFedex.Display("Paqueteria Fedex");

            MetodoEnvios metodoDhlAvion = new DHL(new Avion());
            metodoDhlAvion.Display("Paqueteria DHL");


            MetodoEnvios metodoDhlBarco = new DHL(new Barco());
            metodoDhlBarco.Display("Paqueteria DHL");

            MetodoEnvios metodoEstafeta = new Estafeta(new Tren());
            metodoEstafeta.Display("Paqueteria Estafeta");

            Console.ReadLine();
 
        }
    }
}
