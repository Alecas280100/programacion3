using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorita
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodos;
            double tasa;
            double MontoInicial;
            double InversionInicial;
            
            Console.WriteLine("Introduzca numero de periodos");
            periodos = int.Parse(Console.ReadLine());
            double[] flujos = new double[periodos];
            Console.WriteLine("Introduzca los flujos");
            for(int i=0;i<periodos;i++)
            {
                flujos[i]=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduzca tasa de rendimiento");
            tasa = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el monto inicial");
            MontoInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la inversion inicial");
            InversionInicial =double.Parse(Console.ReadLine());
            CalculadoraFinanciera calc = new CalculadoraFinanciera(periodos,tasa);
            Console.WriteLine("El monto final es"+calc.Montofinal(MontoInicial));          
            Console.WriteLine("El calculo del VAN es"+calc.VAN(InversionInicial, flujos));
            Console.ReadKey();
        }
    }
}
