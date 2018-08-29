using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            cTiendaAutos tienda = new cTiendaAutos();

            foreach (cAuto miAuto in tienda) {
                miAuto.calcularImpuesto(0.02);
                miAuto.muestra();
            }

            Console.ReadLine();
        }
    }
}
