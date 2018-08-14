using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Definicion unidimensional
            int[] miArray = new int[4];
            int[] otroArray = new int[] { 4, 5, 9, 6 };


            //Asignacion
            miArray[0] = 3;
            miArray[1] = 3;
            miArray[2] = 3;
            miArray[3] = 3;


            //recorrer
            foreach (int ind in miArray) {
                Console.WriteLine("el valor es {0}", ind);
            }

            //Definicion multidimensional [fila, columna]
            int[,] multiArray = new int[3,2];


            //Asignacion
            multiArray[0, 0] = 1;
            multiArray[0, 1] = 2;

            multiArray[1, 0] = 3;
            multiArray[1, 1] = 4;

            multiArray[2, 0] = 5;
            multiArray[2, 1] = 6;

            //recorrer
            for (int f = multiArray.GetLowerBound(0); f <= multiArray.GetUpperBound(0); f++) {
                for (int c = multiArray.GetLowerBound(1); c <= multiArray.GetUpperBound(1); c++) {
                    Console.WriteLine("" + multiArray[f, c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
