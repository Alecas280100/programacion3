using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqueda_binaria
{
    class Program
    {
        static int[] vector = { 22, 31, 46, 48, 68, 78, 80 };
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor deseado:");
            int b = int.Parse(Console.ReadLine());
            if (Buscar(vector,b))
            { Console.WriteLine("Se encontro n"); }
            else
            { Console.WriteLine("Sin coincidencias"); }
            Console.ReadKey();
        }
        static Boolean Buscar(int[] vector,int b)
        {
            int i = 0;
            int j = vector.Length;
            int m = (j - 1) / 2 + i;

            while (b!=vector[m]&&(j>(1+i)))
            {
                if (b > vector[m])
                    i = m;
                else
                    j = m;
                m = (j - 1) / 2 + i;
            }
            if (vector[m] == b)
                return true;
            else
                return false;
        }
    }
}
