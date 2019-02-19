using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultas
{
    class Alumno
    {        
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get ; set; }               
        public Alumno(string Apellido, int Edad, string Sexo)
        {            
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Sexo = Sexo;
        }
    }
}
