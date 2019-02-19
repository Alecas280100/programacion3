using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepersona
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get ; set; }
        public string CI { get; set; }
        public double Altura { get ; set; }
        public double Peso { get ; set; }
        public Persona(string Nombre, string Apellido, int Edad, string Sexo, string CI, double Altura, double Peso)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.CI = CI;
            this.Altura = Altura;
            this.Peso = Peso;
        }
    }
}
