using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    class CLibro
    {
        private string nombre;
        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
