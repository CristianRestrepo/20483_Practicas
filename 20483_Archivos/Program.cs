using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivos logicaArchivos = new Archivos("ArchivoPrueba.txt");
            Console.WriteLine("" + logicaArchivos.Ruta);

            logicaArchivos.EscribirArchivoStream();
            logicaArchivos.EscribirArchivoFileStream();
            logicaArchivos.LeerArchivoStream();

            
            Console.ReadKey();
        }
    }
}
