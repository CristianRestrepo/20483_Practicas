using ProyectoIntermedio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio
{
    class cResta : iOperacion
    {
        private double resultado = 0;
        public void calcular(double a, double b)
        {
            resultado = a - b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", resultado);
            Console.ReadLine();
        }
    }
}
