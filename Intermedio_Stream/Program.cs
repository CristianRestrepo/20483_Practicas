using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Intermedio_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            //Cargamos el archivo
            FileStream fs = new FileStream("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            //Obtenemos cantidad
            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);

            //leemos de inicio a fin
            for (n = 0; n < cantidad; n++)
            {
                fs.Seek(n, SeekOrigin.Begin);
                valor = fs.ReadByte();
                Console.Write("{0},",(char)valor);
            }

            Console.WriteLine("\n-------------------------");

            //leemos de fin a inicio
            for (n = 1;  n <= cantidad ; n++)
            {   
                fs.Seek(-n, SeekOrigin.End);
                valor = fs.ReadByte();
                Console.Write("{0},", (char)valor);
            }

            fs.Close();
            Console.ReadLine();
        }
    }
}
