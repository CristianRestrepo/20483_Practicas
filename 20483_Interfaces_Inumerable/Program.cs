using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Interfaces_Inumerable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            cEnumerable datos = new cEnumerable();
            foreach (int valor in datos) {
                Console.WriteLine("{0}", valor);
            }

            Console.ReadKey();
        }
    }
}
