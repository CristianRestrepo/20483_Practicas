using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Colecciones_EjemploSencillo
{
    class Program
    {
        static void Main(string[] args)
        {

            //no genericas
            ArrayList al = new ArrayList();
            Queue cola = new Queue(); //cola
            Stack pila = new Stack(); //pila

            Hashtable table = new Hashtable();
            SortedList lista = new SortedList();

            //maneja datos de tipo object
            al.Add(23);
            al.Add("hola");
            al.Add(true);

            for (int i = 0; i < al.Count; i++)
                Console.WriteLine("el objeto {0}", i);

            //genericas
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //Genericos
            


        }
    }
}
