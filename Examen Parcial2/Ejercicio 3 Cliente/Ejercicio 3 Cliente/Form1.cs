using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Ejercicio_3_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char letra = ' ';
        string palabraAdivinar = "";
        const String ahorca = "C:/Users/Estudiante/programacionIII/Ahorcado/0.png";
        const String ahorca1 = "C:/Users/Estudiante/programacionIII/Ahorcado/1.png";
        const String ahorca2 = "C:/Users/Estudiante/programacionIII/Ahorcado/2.png";
        const String ahorca3 = "C:/Users/Estudiante/programacionIII/Ahorcado/3.png";
        const String ahorca4 = "C:/Users/Estudiante/programacionIII/Ahorcado/4.png";
        const String ahorca5 = "C:/Users/Estudiante/programacionIII/Ahorcado/5.png";
        const String ahorca6 = "C:/Users/Estudiante/programacionIII/Ahorcado/6.png";
        const String ahorca7 = "C:/Users/Estudiante/programacionIII/Ahorcado/7.png";

        private String EnviarMensaje(String Mensaje)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(Mensaje);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  

                    int bytesRec = sender.Receive(bytes);


                    String Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                    return Respuesta;
                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;

        }
    }
}
