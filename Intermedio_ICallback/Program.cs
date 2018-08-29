using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_ICallback
{
    class Program
    {
        static void Main(string[] args)
        {
            cRefrigerador refri = new cRefrigerador(20, 5);

            //Random para generar trabajo en el refri
            Random rnd = new Random();

            cRefriSink refriSink = new cRefriSink();

            refri.AgregarSick(refriSink);

            while (refri.KilosAlimentos > 0) {
                refri.trabajar(rnd.Next(1, 8));
            }

            Console.ReadLine();
        }
    }
}
