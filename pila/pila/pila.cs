using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila
{
    class pila
    {
        public static int max = 10;
        private int[] vector = new int[max];
        private int tope = -1;

        public void push(int n)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = n;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public int pop()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
                Console.WriteLine("La pila esta vacia");
            return -1;
        }
        private Boolean vacia()
        {
            return tope == -1;
        }
        private Boolean llena()
        {
            return tope == max;
        }
        public void mostrar()
        {
            for(int i=0;i<=tope;i++)
            {
                Console.WriteLine("{0}", vector[i]);
            }
        }
    }
}

