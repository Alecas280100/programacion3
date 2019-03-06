using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola_circular
{
    class Circular
    {
        public const int maximo = 10;
        private int[] arreglo = new int[maximo];
        private int frente = 0;
        private int final = 0;

        public void insertar(int valor)
        {
            if (!llena())
            {
                arreglo[final] = valor;
                final = (final + 1) % maximo;
            }
            else
                Console.WriteLine("Cola llena");
        }
        public int Eliminar()
        {
            if (!vacia())
            {
                int valor;
                valor = arreglo[frente];
                frente = (frente + 1) % maximo;
                return valor;
            }
            else
                Console.WriteLine("Cola vacia");
            return arreglo[frente];
        }
        public void mostrar()
        {
            int aux = frente;
            while(aux!=final)
            {
                Console.Write(arreglo[aux] + " ");
                aux = (aux + 1) % maximo;
            }
        }

        private Boolean llena()
        {
            return final == (final + 1) % maximo;
        }

        private Boolean vacia()
        {
            return frente == final;
        }
    }
}
