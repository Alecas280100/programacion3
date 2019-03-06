using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola_circular
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            Circular cir = new Circular();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        cir.insertar(x);
                        break;
                    case 2:
                        x = cir.Eliminar();
                        Console.WriteLine("El elemento eliminado es:" + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        cir.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        break;
                }
            }
        }
    }
}
