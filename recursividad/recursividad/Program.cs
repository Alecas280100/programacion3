using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci(1) = {0}", fibonacci(1));
            Console.WriteLine("Fibonacci(5) = {0}", fibonacci(5));
            Console.WriteLine("Fibonacci(3) = {0}", fibonacci(3));
            Console.ReadKey();
        }

        public static int fibonacci(int n)
        {
            if(n==0)
            { return 0; }
            else if(n==1)
            { return 1; }
            else
            { return fibonacci(n - 1) + fibonacci(n - 2); }
            
        }
    }
}
