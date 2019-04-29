using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject op = SingleObject.getInstance();
            op.ShowMethod();
            SingleObject op2 = SingleObject.getInstance();
            op2.ShowMethod();
            Console.ReadLine();
        }
    }
}
