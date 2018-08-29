using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Interfaces_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            cLibro libro1 = new cLibro();
            cLibro libro2 = new cLibro();
            cLibro libro3 = new cLibro();

            libro1.Nombre = "Nacidos de la bruma";
            libro1.Autor = "Brandon Sanderson";
            libro1.Edicion = 3;

            libro2 = libro1;

            libro1.MostrarInformacion();
            libro2.MostrarInformacion();

            Console.WriteLine("\n------------------------\n");

            libro1.Edicion = 2;

            libro1.MostrarInformacion();
            libro2.MostrarInformacion();

            Console.WriteLine("\n------------------------\n");

            libro3 = (cLibro)libro1.Clone();

            libro1.MostrarInformacion();
            libro3.MostrarInformacion();

            Console.WriteLine("\n------------------------\n");

            libro1.Edicion = 3;
            libro1.MostrarInformacion();
            libro3.MostrarInformacion();

            Console.ReadKey();

        }
    }
}
