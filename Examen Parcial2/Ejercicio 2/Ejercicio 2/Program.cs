using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Ejercicio_2
{
    class Program
    {
        public static string data = null;
        private static int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return factorial(n - 1) * n;
        }
        public static void StartListening()
        {
          
            byte[] bytes = new Byte[1024];
            
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);
             
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
 
                while (true)
                {
                    Console.WriteLine("Esperando por conexiones ...");                     
                    Socket handler = listener.Accept();
                    data = null;


                    int bytesRec = handler.Receive(bytes);

                    int n = BitConverter.ToInt32(bytes, 0);

                    Console.WriteLine("Texto recibido: {0}", n);

                    int fact = factorial(n);
                    
                    byte[] msg = Encoding.ASCII.GetBytes(fact.ToString());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Presione ENTER para continuar...");
            Console.Read();
        }

        static int Main(string[] args)
        {
            StartListening();
            return 0;
        }
    }
}
