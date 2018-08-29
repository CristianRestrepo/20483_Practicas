using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_Indexer
{
    class cAuto
    {
        double costo;
        double impusto;
        string modelo;

        public cAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public void MuestraInformación()
        {
            Console.WriteLine("tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("------------------");
        }
    
    }
}
