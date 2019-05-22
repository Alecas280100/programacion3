using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion_vectores
{
    class Vector
    {
        private int[] vector;
        private int[] vector2;
        private int[] vector3;
        private static Vector Instancia;
        public static Vector getInstance()//Singleton
        {
            if (Instancia == null)
                Instancia = new Vector();

            return Instancia;
        }
        public void sumar()
        {
            Console.WriteLine("El vector suma es:");
            for(int i=0;i<vector.Length;i++)
            {
                for(int j=0;j<vector2.Length;j++)
                {
                    for(int g=0;g<vector3.Length;g++)
                    {
                        vector3[g] = vector[i] + vector2[j];
                        Console.WriteLine(vector3[g]);
                    }
                }
            }
            
        }
         public void restar()
        {
            Console.WriteLine("El vector resta es:");
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector2.Length; j++)
                {
                    for (int g = 0; g < vector3.Length; g++)
                    {
                        vector3[g] = vector[i] - vector2[j];
                        Console.WriteLine(vector3[g]);
                    }
                }
            }
           
        }
        public void multiplicar()
        {
            Console.WriteLine("La multiplicacion es:");
            for(int i=0;i<vector.Length;i++)
            {
                for(int j=0;j<vector2.Length;j++)
                {
                    int mult = 0;
                    mult = mult + (vector[i] * vector2[j]);
                    Console.WriteLine(mult);
                }
            }
            Console.ReadLine();
        }
        public void cargar()
        {
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            vector2 = new int[n];
            vector3 = new int[n];
            Console.WriteLine("Ingrese elementos al primer vector:");
            for(int i=0;i<vector.Length;i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                vector[i] = x;
            }
            Console.WriteLine("Ingrese elementos al segundo vector:");
            for (int i = 0; i < vector2.Length; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                vector2[i] = x;
            }
            
        }
    }
}
