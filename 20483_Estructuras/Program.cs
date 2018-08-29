using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _20483_Estructuras.cEstructuras;

namespace _20483_Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //cPersona p = new cPersona("Cristian", "Restrepo", 24);
            persona p = new persona("Cristian", "Restrepo", 24);

            modificarNombre(p);
            Console.WriteLine("Nombre: " + p.nombre);
            Console.ReadKey();
        }


        public static void modificarNombre(cPersona pPersona) {
            pPersona.nombre = "NombrePrueba";
            Console.WriteLine(pPersona.ToString());
        }

        public static void modificarNombre(persona pPersona)
        {
            pPersona.nombre = "NombrePrueba";
            Console.WriteLine(pPersona.ToString());
        }
    }
}
