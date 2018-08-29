using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_InterfacesII
{
    class Program
    {
        static void Main(string[] args)
        {
            cContenedora datos = new cContenedora();

            foreach (int dato in datos) {
                Console.WriteLine(dato);
            }

            Console.ReadLine();
                        
        }
    }
}
