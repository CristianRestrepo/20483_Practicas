using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_ColeccionesGenericas_Dictionary
{
    class Program
    {
        //Instanciación
        public static IDictionary<int, string> miDiccionario = new Dictionary<int, string>();

        static void Main(string[] args)
        {

            //Agregar elementos
            miDiccionario.Add(1, "Objeto 1");
            miDiccionario.Add(new KeyValuePair<int, string>(2, "Objeto 2"));

            mostrarContenidoDiccionarioForeach();

            Console.ReadKey();
        }


        //public static void mostrarContenidoDiccionarioFor() {


        //    List<string> values = (List<string>)miDiccionario.Values;

        //    Console.WriteLine("\n-----------------for-----------\n");
        //    for (int i = 0; i < miDiccionario.Count; i++) {
        //        Console.WriteLine("Llave: {0}, Valor: {1}", miDiccionario[], );
        //    }
        //}

        public static void mostrarContenidoDiccionarioForeach()
        {
            Console.WriteLine("\n-----------------foreach-----------\n");
            foreach (KeyValuePair<int, string> kvp in miDiccionario)
            {
                Console.WriteLine("Llave: {0}, Valor: {1}", kvp.Key.ToString(), kvp.Value.ToString());
            }
        }
    }
}
