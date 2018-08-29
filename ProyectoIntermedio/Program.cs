using ProyectoIntermedio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double a = 0.0;
            double b = 0.0;
            string valor = "";

            iOperacion operacion = new cSuma();//instacia default

            while (opcion != 5) {

                Console.WriteLine("1:Suma, 2:Resta, 3:Multiplicación, 4:Division, 5:Salir");
                Console.WriteLine("¿Que opcion desea?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt16(opcion);

                Console.WriteLine("Dame el valor de a:");
                valor = Console.ReadLine();
                a = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de b:");
                valor = Console.ReadLine();
                b = Convert.ToDouble(valor);

                //polimorfismo

                if (opcion == 1)
                    operacion = new cSuma();
                if (opcion == 2)
                    operacion = new cResta();
                if (opcion == 3)
                    operacion = new cMultiplicacion();
                if (opcion == 4)
                    operacion = new cDivision();

                operacion.calcular(a, b);
                operacion.mostrar();
            }
        }
    }
}
