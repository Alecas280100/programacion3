using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfigura
{
    class Cuadrado :Ifigura
    {
        private Double lado;
        
        public Cuadrado()
        {
            this.lado = double.Parse(Console.ReadLine());
        }
        public double getArea(double x)
        {
            return x=lado * lado;
        }
        public double getPerimetro(double x)
        {
            return x = 4 * lado;
        }
    }

    class Rectangulo :Ifigura
    {
        private Double basee;
        private Double altura;
        public Rectangulo()
        {
            this.basee = double.Parse(Console.ReadLine());
            this.altura= double.Parse(Console.ReadLine());
        }
        public double getArea(double x)
        {
           return x = basee * altura; 
        }
        public double getPerimetro(double x)
        {
           return x = (2 * basee) + (2 * altura);
        }
    }

    class Circulo : Ifigura
    {
        private Double radio;

        public Circulo()
        {
            this.radio = double.Parse(Console.ReadLine());
        }
        public double getArea(double x)
        {
            return
        }
        public double getPerimetro(double x)
        {

        }
    }
}
