using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_Interfaces
{
    class cTiendaAutos
    {
        private cAuto[] disponibles;
        public cTiendaAutos()
        {
            disponibles = new cAuto[4];

            disponibles[0] = new cAuto("Camaro", 250000);
            disponibles[1] = new cAuto("Dodge", 350000);
            disponibles[2] = new cAuto("Vyper", 210000);
            disponibles[3] = new cAuto("Spark", 120000);
        }

        public IEnumerator GetEnumerator() {
            return disponibles.GetEnumerator();
        }

    }
}
