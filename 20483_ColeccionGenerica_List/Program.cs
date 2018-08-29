using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_ColeccionGenerica_List
{
    class Program
    {

        //Implementacion
        public static List<string> miLista = new List<string>();

        static void Main(string[] args)
        {
            //Agregar elementos
            miLista.Add("Objeto 1");
            miLista.Add("Objeto 2");

            mostrarElementos();

            //Insertar elemento en un indice especifico
            Console.WriteLine("\nSe inserta elemento");
            miLista.Insert(0, "Objeto 3");

            mostrarElementos();

            //Obtenemos indice de un objeto
            Console.WriteLine("\nSe obtiene indice de un elemento");
            int indice = miLista.IndexOf("Objeto 3");
            Console.WriteLine("el objeto 'Objeto 3' esta ubicado en el indice {0}", indice);

            //probamos la propiedad capacity de la lista
            miLista.Add("Objeto 4");
            miLista.Add("Objeto 5");
            //miLista.Capacity = 4; //Genera error pues la lista posee mas elementos
            //Debe generar excepcion

            mostrarElementos();
            Console.ReadKey();
        }

        public static void mostrarElementos()
        {
            foreach (string objeto in miLista)
            {
                Console.WriteLine("{0}", objeto);
            }

        }
    }
}
