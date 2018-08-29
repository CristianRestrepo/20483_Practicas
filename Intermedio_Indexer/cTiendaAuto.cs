using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_Indexer
{
    class cTiendaAuto
    {
        private cAuto[] disponibles;

        public cTiendaAuto()
        {
            disponibles = new cAuto[2];

            disponibles[0] = new cAuto("Soul", 22000);
            disponibles[1] = new cAuto("Spark", 25000);
        }


        //Creamos el indexer
        public cAuto this[int indice]
        {
            get { return disponibles[indice]; }
            set { disponibles[indice] = value; }
        }

    }
}
