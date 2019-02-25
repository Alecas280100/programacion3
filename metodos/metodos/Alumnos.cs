using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Alumnos
    {
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public Alumnos(string Apellido, int Edad, string Sexo)
        {
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Sexo = Sexo;
        }
    }
}
