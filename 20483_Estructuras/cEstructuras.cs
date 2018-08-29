using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Estructuras
{
    class cEstructuras
    {
        //Definicion de tipo struct
        public struct persona
        {
            public string nombre;
            public string apellido;
            public int edad;

            public persona(string pNombre, string pApellido, int pEdad)
            {
                nombre = pNombre;
                apellido = pApellido;
                edad = pEdad;
            }

            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("Nombre: {0}, Apellido: {1}, Edad: {2}", nombre, apellido, edad);
                return cadena.ToString();
            }
        }

    }
}
