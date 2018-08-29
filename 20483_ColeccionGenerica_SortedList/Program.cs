using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_ColeccionGenerica_SortedList
{
    class Program
    {
        //definicion
        public static SortedList<int, string> miLista = new SortedList<int, string>();

        static void Main(string[] args)
        {

            //Uso de metodos
            //Se agregan objetos a la coleccion
            miLista.Add(1, "Objeto 1");
            miLista.Add(2, "Objeto 2");
            miLista.Add(3, "Objeto 3");
            miLista.Add(4, "Objeto 4");


            Console.WriteLine("----------For----------");
            MostrarElementosFor();
            Console.WriteLine("--------ForEach------------");
            MostrarElementosForEach();

            Console.WriteLine("\n-----------------------\n");

            //Se elimina elementos y se hace uso de indexOf 
            //para obtener la posicion de un elemento en la lista

            miLista.Remove(1); // recibe como parametro la llave
            int indice = miLista.IndexOfKey(2);
            miLista.RemoveAt(indice);

            Console.WriteLine("----------For----------");
            MostrarElementosFor();
            Console.WriteLine("--------ForEach------------");
            MostrarElementosForEach();

         

            //uso del trygetvalue
            string valor = "";
            if (miLista.TryGetValue(3, out valor)) {
                Console.WriteLine("el objeto existe");
            }

            if (!miLista.TryGetValue(1, out valor)) 
            {
                Console.WriteLine("el objeto no existe");
            }

            Console.ReadKey();
        }

        public static void MostrarElementosFor()
        {
            //uso de todas las propiedades del sortedList
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.WriteLine("Llave: {0},Valor: {1}", miLista.Keys[i], miLista.Values[i].ToString());
            }

        }

        public static void MostrarElementosForEach()
        {
            foreach (KeyValuePair<int, string> kvp in miLista)
            {
                Console.WriteLine("Llave: {0},Valor: {1}", kvp.Key.ToString(), kvp.Value.ToString());
            }
        }
    }
}
