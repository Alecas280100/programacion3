using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string edad ;
            string nombre,sexo,carrera;
            ColaCircular<string> p = new ColaCircular<string>();
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por delante");
                Console.WriteLine("2. Insertar por detras");
                Console.WriteLine("3. Eliminar por delante");
                Console.WriteLine("4. Eliminar por detras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca un Nombre");
                        nombre = Console.ReadLine();
                        p.InsertarDelante(nombre);
                        Console.WriteLine("Introduzca la edad");
                        edad = Console.ReadLine();
                        p.InsertarDelante(Convert.ToString(edad));
                        Console.WriteLine("Introduzca el sexo");
                        sexo = Console.ReadLine();
                        p.InsertarDelante(sexo);
                        Console.WriteLine("Introduzca la carrera");
                        carrera = Console.ReadLine();
                        p.InsertarDelante(carrera);
                        break;
                    case 2:
                        Console.WriteLine("Introduzca un Nombre");
                        nombre = Console.ReadLine();
                        p.InsertarDetras(nombre);
                        Console.WriteLine("Introduzca la edad");
                        edad = Console.ReadLine();
                        p.InsertarDetras(Convert.ToString(edad));
                        Console.WriteLine("Introduzca el sexo");
                        sexo = Console.ReadLine();
                        p.InsertarDetras(sexo);
                        Console.WriteLine("Introduzca la carrera");
                        carrera = Console.ReadLine();
                        p.InsertarDetras(carrera);
                        break;
                    case 3:
                        nombre = p.EliminarDelante();
                        edad = p.EliminarDelante();
                        sexo = p.EliminarDelante();
                        carrera = p.EliminarDelante();
                        Console.WriteLine("El elemento eliminado es {0} {1} {2} {3}", nombre,edad,sexo,carrera);
                        Console.ReadKey();
                        break;
                    case 4:
                        nombre = p.EliminarDetras();
                        edad = p.EliminarDetras();
                        sexo = p.EliminarDetras();
                        carrera = p.EliminarDetras();
                        Console.WriteLine("Los elementos eliminados son {0} {1} {2} {3}", nombre, edad, sexo, carrera);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 6:
                        opcion = 6;
                        break;
                }

            }
        }
    }
}
