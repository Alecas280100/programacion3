using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos[] Alum = new Alumnos[7];
            Alum[0] = new Alumnos("Castro", 19, "Masculino");
            Alum[1] = new Alumnos("La Torre", 18, "Masculino");
            Alum[2] = new Alumnos("Adamczyk", 18, "Masculino");
            Alum[3] = new Alumnos("Lopez", 19, "Femenino");
            Alum[4] = new Alumnos("Guzman", 18, "Femenino");
            Alum[5] = new Alumnos("Quiñones", 19, "Masculino");
            Alum[6] = new Alumnos("Zarate", 19, "Masculino");

            var metodo1 = Alum;
             foreach(Alumnos al in metodo1)
            { Console.WriteLine("{0} {1} {2}", al.Apellido, al.Edad, al.Sexo); }

            var metodo2 = Alum.Where(d => d.Edad > 18);

        }
    }
}
