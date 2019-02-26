using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqeuda_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10] { 54, 26, 93, 17, 77, 31, 44, 55, 20, 65 };
            seleccion(arreglo);
            int n = int.Parse(Console.ReadLine());
            if(buscar(arreglo,n))
            { Console.WriteLine("Se encontro n"); }
            else
            { Console.WriteLine("Sin coincidencias"); }
            Console.ReadKey();
        }

        static Boolean buscar(int[] arreglo,int n)
        {
            Boolean aux;
            for(int i=0;i<arreglo.Length;i++)
            {
                if (arreglo[i] == n)
                    Console.WriteLine(arreglo[i]);
            }
            return true;
        }
        static void seleccion(int[] arreglo)
        {
            int aux = 0;
            for(int i=0;i<arreglo.Length;i++)
            {
                for(int j=0;j<arreglo.Length; j++)
                {
                    if(arreglo[i]<arreglo[j])
                    {
                        aux = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = aux;
                    }
                }
            }
        }
    }
}
