using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Preguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadProc));
            Thread t2 = new Thread(new ThreadStart(ThreadProc2));
            t.Start();
            t2.Start();
            t2.Join();
            t.Abort();
            Console.WriteLine("Su puntaje es 10");
            Console.ReadKey();
        }

        public static void ThreadProc()
        {
            string pregunta = "";
            string respuesta = "";
            Console.WriteLine("Procedimiento preguntas:");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Pregunta 1");
                    pregunta = "Dios del rayo segun griegos";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine("Pregunta 2");
                    pregunta = "Capital de Egipto";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine("Pregunta 3");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine("Pregunta 4");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 5)
                {
                    Console.WriteLine("Pregunta 5");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 6)
                {
                    Console.WriteLine("Pregunta 6");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 7)
                {
                    Console.WriteLine("Pregunta 7");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 8)
                {
                    Console.WriteLine("Pregunta 8");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 9)
                {
                    Console.WriteLine("Pregunta 9");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
                if (i == 10)
                {
                    Console.WriteLine("Pregunta 10");
                    pregunta = "";
                    Console.WriteLine(pregunta);
                    respuesta = Console.ReadLine();
                }
            }
            
        }
        public static void ThreadProc2()
        {
            Thread.Sleep(6000);
            Console.WriteLine("TIEMPO AGOTADO");
        }       
    }
}
