using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Interfaces_IClonable
{
    class cLibro : ICloneable
    {
        private string nombre;
        private int edicion;
        private string autor;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edicion
        {
            get { return edicion; }
            set { edicion = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public void MostrarInformacion() {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Autor: {0}", autor);
            Console.WriteLine("Edicion: {0}", edicion);
        }

        public object Clone()
        {
            cLibro libro = new cLibro();
            libro.nombre = this.nombre;
            libro.edicion = this.edicion;
            libro.autor = this.autor;
            return libro;
        }
    }
}
