using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoEstudio
{
    class cCalculadora
    {
        //Metodo Suma
        public static int Suma(int a, int b) {
            int r = 0;
            r = a + b;
            return r;
        }

        //Sobrecarga del método suma
        public double Suma(double a, double b)
        {
            double r = 0;
            r = a + b;
            return r;
        }

    }
}
