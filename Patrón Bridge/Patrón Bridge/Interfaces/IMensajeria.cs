using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Bridge.Bridge
{
    public interface IMensajeria
    {
        void RecogerPedido();
        void EnviarPedido();
        void EntregarPedido();
        void Display(string text);
    }
}
