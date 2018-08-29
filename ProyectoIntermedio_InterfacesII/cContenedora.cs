using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoIntermedio_InterfacesII
{
    class cContenedora : IEnumerable
    {
        private int[] valores = new int[10];
        public cContenedora()
        {
            for (int i = 0; i < 10; i++){
                valores[i] = i * i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new cContenedorEnum(valores));
        }

        
    }
}
