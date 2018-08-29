using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoEstudio
{
    class cAlumno
    {

        private EstadosUsuario estadoUsuario;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public EstadosUsuario EstadoUsuario
        {
            get { return estadoUsuario; }
            set { estadoUsuario = value; }
        }


    }
}
