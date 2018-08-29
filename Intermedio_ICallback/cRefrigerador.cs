using Intermedio_ICallback.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_ICallback
{
    class cRefrigerador
    {
        private ArrayList listaSinks = new ArrayList();
        
        private int kilosAlimentos = 0;
        private int grados;

        //Propiedades
        public int Grados
        {
            get { return grados; }
            set { grados = value; }
        }
        
        public int KilosAlimentos
        {
            get { return kilosAlimentos; }
            set { kilosAlimentos = value; }
        }


        //Metodos
        public cRefrigerador(int pKilosAlimentos, int pGrados)
        {
            kilosAlimentos = pKilosAlimentos;
            grados = pGrados;
        }


        public void AgregarSick(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }

        public void EliminarSick(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }


        public void trabajar(int pConsumo)
        {
            kilosAlimentos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Grados {0}, Kilos {1}", grados, kilosAlimentos);

            if (kilosAlimentos < 10)
            {
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.ReservaBaja(2);
                }
            }
        }

    }
}
