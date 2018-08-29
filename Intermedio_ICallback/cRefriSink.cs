using Intermedio_ICallback.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_ICallback
{
    class cRefriSink : IEventosRefri
    {
        public void ReservaBaja(int pKilo)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Reserva baja de alimentos");
            Console.WriteLine("Quedan [0] kilos", pKilo);
        }
    }
}
