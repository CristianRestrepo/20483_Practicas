using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_Nombrados
{
    class Program
    {
        static void Main(string[] args)
        {
            //invocamos metodos enviando un parametro nombrado
            mostrar(3, pC: 18, pB: 8);

            //un nombrado no puede ir antes de un posicional
            //mostrar(pC: 18, 3, pC: 8);
            Console.WriteLine("\n------------------------------");

            //opcional1 
            mostrarOpcionales(3, pC: 15);
            Console.ReadLine();
        }


        public static void mostrar(int pA, int pB, int pC)
        {
            Console.WriteLine("pA: {0}", pA);
            Console.WriteLine("pB: {0}", pB);
            Console.WriteLine("pC: {0}", pC);
        }

        public static void mostrarOpcionales(int pA = 1, int pB= 2, int pC = 3)
        {

            Console.WriteLine("pA: {0}", pA);
            Console.WriteLine("pB: {0}", pB);
            Console.WriteLine("pC: {0}", pC);
        }
    }
}
