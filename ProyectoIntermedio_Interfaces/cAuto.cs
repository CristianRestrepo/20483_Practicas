using ProyectoIntermedio_Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_Interfaces
{
    class cAuto : IAutomovil
    {
        string modelo = "";
        double costo = 0.0;
        double impuesto = 0.0;

        public cAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public void calcularImpuesto(double pImpuesto)
        {
            impuesto = (1000 + costo) * pImpuesto;
        }

        public void muestra()
        {
            Console.WriteLine("El impuesto para el vehiculo {0} es {1}", modelo, impuesto);
            Console.WriteLine("------------");
        }
    }
}
