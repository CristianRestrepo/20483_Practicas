using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Interfaces_Inumerable
{
    class cEnumerable : IEnumerable
    {
        private int[] datos = new int[5];

        public cEnumerable()
        {
            for (int i = 0; i < datos.Length; i++ )
            {
                datos[i] = i;
            }            
        }

        public IEnumerator GetEnumerator()
        {
            return new cEnumerator(datos);
        }
    }
}
