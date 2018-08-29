using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoEstudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int rInt = 0;
            double rDouble = 0.0;

            cCalculadora calculadora = new cCalculadora();

            rInt = cCalculadora.Suma(5, 3);
            Console.WriteLine("El resultado es {0}", rInt);

            rDouble = calculadora.Suma(10.5, 23.45);
            Console.WriteLine("El resultado es {0}", rDouble);


            cAlumno alumno = new cAlumno();
            alumno.EstadoUsuario = EstadosUsuario.Activo;

        }
    }
}
