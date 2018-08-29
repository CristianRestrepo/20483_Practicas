using _20483_Colecciones.Clases;
using _20483_Colecciones.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20483_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int opcion = 1;

            Console.WriteLine("!!!Bienvenido a su libreria anarquista¡¡¡");
            cProcesosLibreria libreria = new cProcesosLibreria();
            cLibro libro;

            while (opcion >= 1 && opcion <= 7)
            {

                Console.WriteLine("\nA Continuación le mostraremos las diferentes acciones que puede realizar en el sistema.");
                Console.WriteLine("1. Agregar libro a la libreria");
                Console.WriteLine("2. Prestar Libro");
                Console.WriteLine("3. Validar cantidad de libros disponibles");
                Console.WriteLine("4. Mostrar Libros disponibles");
                Console.WriteLine("5. Registrar Precio");
                Console.WriteLine("6. Consultar Precio");
                Console.WriteLine("7. Consultar todos los precios");
                Console.WriteLine("8. Salir");
                valor = Console.ReadLine();
                opcion = int.Parse(valor);

                switch (opcion)
                {
                    case 1:
                        libro = new cLibro();
                        Console.WriteLine("Bienvenido al sistema de registro de libros, por favor indique los siguiente datos:");
                        Console.WriteLine("Nombre del libro:");
                        libro.Nombre = Console.ReadLine();

                        Console.WriteLine("Autor:");
                        libro.Autor = Console.ReadLine();

                        Console.WriteLine("Editorial:");
                        libro.Editorial = Console.ReadLine();

                        libreria.AgregarLibro(libro);
                        break;

                    case 2:
                        libreria.PrestarLibro();
                        break;

                    case 3:
                        libreria.ConsultarCantidadLibros();
                        break;

                    case 4:
                        libreria.MostrarLibrosDisponibles();
                        break;

                    case 5:
                        libreria.RegistrarPrecioLibro();
                        break;

                    case 6:
                        libreria.ConsultarPrecioLibro();
                        break;

                    case 7:
                        libreria.ConsultarListaDePrecios();
                        break;

                }

            }

            Console.ReadKey();

        }
    }
}
