using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_InterfacesII
{
    class cContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public cContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
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
