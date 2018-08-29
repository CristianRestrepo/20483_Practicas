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
        private Hashtable precios = new Hashtable();


        //Propiedades
        public ArrayList ListaLibros {
            get { return listaLibros; }
            set { listaLibros = value; }
        }

        public Hashtable ListaPrecios {
            get { return precios; }
            set { precios = value; }
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

        public void ConsultarListaDePrecios()
        {
            int indice = 0;
            Console.WriteLine("Los precios de los productos");
            foreach (DictionaryEntry datos in precios) {
                indice++;
                Console.WriteLine("{0}. {1}:  {2}", indice, datos.Key, datos.Value);
            }
        }

        public void ConsultarPrecioLibro()
        {
            string valor = "";
            Console.WriteLine("Libros disponibles");
            MostrarLibrosDisponibles();
            Console.WriteLine("Indique el libro del que desea conocer el precio:");
            valor = Console.ReadLine();

            cLibro libro = (cLibro)listaLibros[int.Parse(valor)];
            Console.WriteLine("El costo del libro {0} es {1}", libro.Nombre, (int)precios[libro.Nombre]);
        }

        public void EliminarLibro()
        {
            Console.WriteLine("------------------------------------------------\n");
            string valor = "";
            Console.WriteLine("Que libro desea prestar");
            MostrarLibrosDisponibles();
            Console.WriteLine("indique el indice numerico del libro a prestar");
            valor = Console.ReadLine();

            cLibro libro = (cLibro)listaLibros[int.Parse(valor)];
            listaLibros.Remove(libro);
            Console.WriteLine("libro removido");
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
            Console.WriteLine("indique el indice numerico del libro a remover");
            valor = Console.ReadLine();

            cLibro libro = new cLibro();
            libro =  (cLibro)listaLibros[int.Parse(valor)];
            listaLibros.RemoveAt(int.Parse(valor));
            
            //listaLibros.Sort(); 
            return libro;
        }

        public void RegistrarPrecioLibro()
        {
            string valor;
            int indice; 
            Console.WriteLine("Registro de precios");
            MostrarLibrosDisponibles();
            Console.WriteLine("Indique indice  del libro desea registrarle precio:");
            indice = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique precio:");
            valor = Console.ReadLine();

            cLibro libro = new cLibro();
            libro = (cLibro)listaLibros[indice];
            precios.Add(libro.Nombre, int.Parse(valor));
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
