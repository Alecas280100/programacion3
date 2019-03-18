using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_parcial
{
    class pilita
    {
        public static int cant = 10;
        private string[] vector = new string[cant];
        private int tope = -1;

        public void insertarNombre(string n)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = n;
            }
            else
                Console.WriteLine("La pila esta llena");
        }

        public void insertarEdad(int n)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = Convert.ToString(n);
            }
            else
                Console.WriteLine("La pila esta llena");
        }
         public void insertarSexo(string n)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = n;
            }
            else
                Console.WriteLine("La pila esta llena");
        }

        public void insertarCarrera(string n)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = n;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public string eliminarstring()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
                Console.WriteLine("La pila esta vacia");
            return Convert.ToString(-1);
        }
        public int eliminaredad()
        {
            if (!vacia())
            {
                tope--;
                return int.Parse((vector[tope + 1]));
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
            return tope == cant;
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine("{0}", vector[i]);
            }
        }
    }
}
