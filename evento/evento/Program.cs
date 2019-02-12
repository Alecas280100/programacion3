using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evento
{
    class Program
    {
        private static int n;
        static void Main(string[] args)

        {
            int n;
            n = int.Parse(Console.ReadLine());
            Operaciones o = new Operaciones();
            o.CuandoFactorial += Sumatoria;
            Console.WriteLine("El factorial es {0}", o.Factorial(n));
            Console.ReadKey();            
        }

        static void Sumatoria(int x)
        {
            int aux=0;        
            for(int i=0; i<=x;i++)
            { aux = aux + i; }
            Console.WriteLine("La sumatoria es{0}", aux);
            Console.ReadKey();
        }
    }
    

    public class Operaciones
    {
        public delegate void Delegado(int n);
        public event Delegado CuandoFactorial;
        public int Factorial(int n)
        {
            int x=1;
            for(int i = 1; i<=n;i++)
            {
                x = x * i;
            }
            if((x % 3 == 0 && CuandoFactorial!=null))
            {
                CuandoFactorial(n);
            }
            return x;
        }
    }
}
