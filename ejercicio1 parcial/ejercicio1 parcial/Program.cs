using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            pilita p = new pilita();
            int opcion = 0;
            string x;
            int y = 0;
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
                        Console.WriteLine("Insertar Nombre");
                        x = Console.ReadLine();
                        p.insertarNombre(x);
                        Console.WriteLine("Insertar Edad");
                        y = int.Parse(Console.ReadLine());
                        p.insertarEdad(y);
                        Console.WriteLine("Insertar Sexo");
                        x = Console.ReadLine();
                        p.insertarSexo(x);
                        Console.WriteLine("Insertar Carrera");
                        x = Console.ReadLine();
                        p.insertarCarrera(x);
                        break;                   
                    case 2:
                        x = p.eliminarstring();
                        Console.WriteLine("Se elimino el nombre:" + x);
                        y = p.eliminaredad();
                        Console.WriteLine("Se elimino la edad:" + y);
                        x = p.eliminarstring();
                        Console.WriteLine("Se elimino el sexo:" + x);
                        x = p.eliminarstring();
                        Console.WriteLine("Se elimino la carrera:" + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
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
