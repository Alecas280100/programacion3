using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ejercicio_3_Servidor
{
    class Program
    {
        string data = "";
        static void Main(string[] args)
        {
            byte[] bytes = new Byte[1024];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            String Respuesta = "";
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                while (true)
                {
                    Console.WriteLine("Esperando por conexiones ...");
                    Socket handler = listener.Accept();
                    // La conexion de entrada necesita ser procesada.  
                    int bytesRec = handler.Receive(bytes);
                    string solicitud = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (solicitud == "Iniciar")
                    {
                        Ahorcado.getInstancia().Iniciar();
                        Respuesta = "ok";
                    }
                    else if (solicitud == "Buscar")
                    
                        Respuesta = Ahorcado.getInstancia().Buscar(' ');
                    else if(solicitud=="BuscarPalabra")
                    {
                        Respuesta = Ahorcado.getInstancia().BuscarPalabra("");
                    }
                    byte[] msg = Encoding.ASCII.GetBytes(Respuesta);
                    handler.Send(msg);
                    Console.WriteLine("Texto recibido: {0}", solicitud);
                    Console.WriteLine("Texto enviado: {0}", Respuesta);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }
    }
}
