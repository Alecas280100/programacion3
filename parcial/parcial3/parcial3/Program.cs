using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial3
{
    class Program
    {
        public class multiplo
        {
            public delegate void Delegado(int a); 
            public event Delegado CuandoRecibaMultiplotres; 
            public void multiplicacion(int x, int y, int z)
            {
                int multi=(x*y*z);
                if ((multi) % 2 == 3) 
                { CuandoRecibaMultiplotres(multi); }
                
            }
        }
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Introduzca valor a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca valor b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca valor c");
            c = int.Parse(Console.ReadLine());
            multiplo m = new multiplo();
            m.CuandoRecibaMultiplotres += mult3;
            Console.WriteLine("Multiplo de 3");
            Console.ReadKey();
        }
        static void mult3(int x)
        {
            double div = x / 3;
            Console.WriteLine(div);
        }
    }
    
}
