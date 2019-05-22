using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector.getInstance().cargar();
            Vector.getInstance().sumar();
            Vector.getInstance().restar();
            Vector.getInstance().multiplicar();
            Console.ReadKey();
        }
    }
}
