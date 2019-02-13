using System;

namespace fibonaci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int x = a;
                a = b;
                b = x + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine(Fibonacci(i));
                Console.ReadKey();
            }
        }
    }
}