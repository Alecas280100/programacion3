using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            pila p = new pila();
            int opcion = 0;
            int x = 0;
            while(salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        p.push(x);
                        break;
                    case 2:
                        x = p.pop();
                        Console.WriteLine("El elemento eliminado es:" + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        
                        break;
                }
            }
        }
    }
}
