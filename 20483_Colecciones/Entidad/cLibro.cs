using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Colecciones.Entidad
{
    class cLibro
    {
        private string nombre;
        private string editorial;
        private string autor;

        public string Autor {
            get { return autor; }
            set { autor = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
