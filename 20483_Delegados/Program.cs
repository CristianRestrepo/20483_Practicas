using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Delegados
{
    class Program
    {
        public delegate void delegado(string pEstado);
        static void Main(string[] args)
        {
            delegado funcion = MostrarMensaje;
            funcion("Hola mundo");
            Console.ReadKey();
        }

        public static void MostrarMensaje(string pMensaje) {
            Console.WriteLine("El mensaje es: {0}", pMensaje);
        }
    }
}
