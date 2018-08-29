using _20483_Colecciones.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20483_Colecciones.Entidad;

namespace _20483_Colecciones.Clases
{
    class cProcesosLibreriaStack : IProcesosLibreria
    {

        Stack colaLibros = new Stack();

        public void AgregarLibro(cLibro pLibro)
        {
            colaLibros.Push(pLibro);
        }

        public void ConsultarCantidadLibros()
        {
            Console.WriteLine("La Cantidad de libros en la cola es de {0}", colaLibros.Count);
        }

        public void ConsultarListaDePrecios()
        {
            throw new NotImplementedException();
        }

        public void ConsultarPrecioLibro()
        {
            throw new NotImplementedException();
        }

        public void EliminarLibro()
        {
            //no se puede eliminar objeto, pues la cola no maneja indices
            //debe atenderse la cola uno a uno para liberar la cola.
        }

        public void MostrarLibrosDisponibles()
        {
            Console.WriteLine("------------------------------------------------\n");
            int i = 0;
            foreach (cLibro libro in colaLibros)
            {
                Console.WriteLine("\n{0}. {1}", i, libro.Nombre);
                i++;
            }
        }

        public cLibro PrestarLibro()
        {
            cLibro libro = new cLibro();
            libro = (cLibro)colaLibros.Pop();
            return libro;
        }

        public void RegistrarPrecioLibro()
        {
            throw new NotImplementedException();
        }

        public bool VerificarExistenciaLibro(cLibro pLibro)
        {
            return true;
        }
    }
}
