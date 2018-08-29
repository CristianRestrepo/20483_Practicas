using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20483_Colecciones.Entidad;

namespace _20483_Colecciones.Interfaces
{
    interface IProcesosLibreria
    {
        void AgregarLibro(cLibro pLibro);

        bool VerificarExistenciaLibro(cLibro pLibro);

        void ConsultarCantidadLibros();

        cLibro PrestarLibro();

        void MostrarLibrosDisponibles();

        void EliminarLibro();

        void RegistrarPrecioLibro();

        void ConsultarListaDePrecios();

        void ConsultarPrecioLibro();
    }
}
