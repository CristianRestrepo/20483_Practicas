using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar();
            
        }

        static void Conectar() {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.0.8"), 8888);

            byte[] recibido = new byte[255];

            try
            {
                socket.Bind(direccion);
                socket.Listen(1);

                Console.WriteLine("En espera...");
                Socket escucha = socket.Accept();
                Console.WriteLine("Conexion Exitosa");


                int x = escucha.Receive(recibido, 0, recibido.Length, 0);
                Array.Resize(ref recibido, x);

                Console.WriteLine("El cliente dice {0}", Encoding.Default.GetString(recibido));

                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión, Error: " + ex.Message.ToString());
            }
            Console.ReadKey();

        }
    }
}
