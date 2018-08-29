using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Interfaces_Inumerable
{
    class cEnumerator : IEnumerator
    {
        private int[] miLista;
        private int posicion;
        public cEnumerator(int[] pMiLista)
        {
            miLista = pMiLista;
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return miLista[posicion];
            }
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < miLista.Length)
                return true;
            else
                return false;
            
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
