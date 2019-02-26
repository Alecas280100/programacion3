using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqueda_secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            vector[0] = 54;
            vector[1] = 26;
            vector[2] = 93;
            vector[3] = 17;
            vector[4] = 77;
            vector[5] = 31;
            vector[6] = 44;
            vector[7] = 55;
            vector[8] = 20;
            vector[9] = 27;

            Console.WriteLine("Ingrese el numero que busca:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i<vector.Length;i++)
            {
                if(vector[i]==n)
                {
                    Console.WriteLine("Se encontro el valor {0}",vector[i]);
                }              
            }
            Console.ReadKey();

        }
    }
}
