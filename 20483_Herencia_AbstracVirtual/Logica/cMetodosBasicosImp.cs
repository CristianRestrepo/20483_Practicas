using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20483_Herencia_AbstracVirtual.Abstractas;

namespace _20483_Herencia_AbstracVirtual.Logica
{
    class cMetodosBasicosImp : CMetodosBasicos
    {
        public override void MuestraMensaje()
        {
            throw new NotImplementedException();
        }

        public override void ObtenerObjeto()
        {
            throw new NotImplementedException();
        }

        public virtual void MuestraMensajePadre()
        {

        }
    }
}
