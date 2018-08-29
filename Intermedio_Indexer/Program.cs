using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermedio_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            //Creamos tienda
            cTiendaAuto tienda = new cTiendaAuto();

            //Obtenemos auto
            cAuto auto = tienda[1];
            auto.MuestraInformación();

            //colocamos auto
            cAuto otroAuto = new cAuto("Ford", 100000);
            tienda[1] = otroAuto;

            for (int i = 0; i < 2; i++) {
                tienda[i].MuestraInformación();
            }

            Console.ReadLine();

        }
    }
}
