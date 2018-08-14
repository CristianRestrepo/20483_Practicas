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
    class cProcesosLibreria : IProcesosLibreria
    {

        //Atributos
        private ArrayList listaLibros = new ArrayList();


        //Propiedades
        public ArrayList ListaLibros {
            get { return listaLibros; }
            set { listaLibros = value; }
        }

        //Metodos
        public void AgregarLibro(cLibro pLibro)
        {
            listaLibros.Add(pLibro);
            Console.WriteLine("Libro {0} agregado a la colección", pLibro.Autor);
        }

        public void ConsultarCantidadLibros()
        {
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("La cantida de libros disponibles es de {0} libros", listaLibros.Count);
        }

        public void MostrarLibrosDisponibles()
        {
            Console.WriteLine("------------------------------------------------\n");
            int i = 0;
            foreach (cLibro libro in listaLibros) {
                Console.WriteLine("\n{0}. {1}", i, libro.Nombre);
                i++;
            }

        }

        public cLibro PrestarLibro()
        {
            Console.WriteLine("------------------------------------------------\n");
            string valor = "";
            Console.WriteLine("Que libro desea prestar");
            MostrarLibrosDisponibles();
            Console.WriteLine("indique el indice numerico del libro a retirar");
            valor = Console.ReadLine();

            cLibro libro = new cLibro();
            libro =  (cLibro)listaLibros[int.Parse(valor)];
            return libro;
        }

        public bool VerificarExistenciaLibro(cLibro pLibro)
        {
            Console.WriteLine("------------------------------------------------\n");
            bool respuesta;
            respuesta = listaLibros.Contains(pLibro);
            return respuesta;
        }
    }
}
