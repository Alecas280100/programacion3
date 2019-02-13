using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean salir = new Boolean();
            while (salir == false)
            {
                stocktienda inven = new stocktienda();
                inven.Cuandomenor5 += loque;
                Console.WriteLine("1. Incrementar");
                Console.WriteLine("2. Disminuir");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elija una opcion");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Introduzca n");
                        int n = int.Parse(Console.ReadLine());
                        inven.Incrementarstock(n);
                        break;
                    case 2:
                        Console.Write("Introduzca n");
                        n = int.Parse(Console.ReadLine());
                        inven.Disminuirstock(n);
                        break;
                    case 3:
                        inven.Mostrarstock();
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
        static void loque(int n)
        {
            Console.WriteLine("El stock esta en su minimo {0}", n);
            Console.ReadKey();
        }
    }

    class stocktienda
    {
        private int stock = 0;
        public delegate void Mstock(int n);
        public event Mstock Cuandomenor5;
        public void Incrementarstock(int n)
        {
            this.stock += n;
            if(this.stock<5 && Cuandomenor5!=null)
            { Cuandomenor5(this.stock); }
            
        }
        public void Disminuirstock(int n)
        {
            this.stock -= n;
            if(stock<n)
            { Console.WriteLine("No se dispone de esa cantidad"); }
            else
            { }
        }
        public void Mostrarstock()
        {
            Console.WriteLine("El stock actual es:{0}", this.stock);
        }
    }
}
