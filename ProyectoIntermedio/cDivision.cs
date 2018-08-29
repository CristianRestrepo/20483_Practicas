using ProyectoIntermedio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio
{
    class cDivision : iOperacion
    {
        private double resultado = 0;
        public void calcular(double a, double b)
        {
            resultado = a / b;
        }

        public void mostrar()
        {
            Console.WriteLine("El Resultado de la división es {0}", resultado);
        }
    }
}
