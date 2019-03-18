using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad_tabla3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tabla3(1) = {0}", tabla3(1));
            Console.ReadKey();
        }

        public static int tabla3(int n)
        {
            if (n == 1)
                return 3;
            else
                return tabla3(n - 1) + 3;
        }
    }
}
