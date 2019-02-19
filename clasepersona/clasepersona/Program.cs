using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "Castro", 19, "Masculino", "7483306", 1.69, 70);
            Alumnos[1] = new Persona("Diego", "La Torre", 18, "Masculino", "5454542", 1.75, 75);
            Alumnos[2] = new Persona("Franco", "Adamczyk", 18, "Masculino", "54545787", 1.73, 60);
            Alumnos[3] = new Persona("Carolina", "Lopez", 19, "Femenino", "7110684", 1.67, 60);
            Alumnos[4] = new Persona("Rossimar", "Guzman", 18, "Femenino", "3684541", 1.50, 42);
            Alumnos[5] = new Persona("Dieter", "Quiñones", 19, "Masculino", "7878100", 1.67, 60);
            Alumnos[6] = new Persona("Gustavo", "Zarate", 19, "Masculino", "3268974", 1.74, 62);
            var consulta = from alm in Alumnos
                           select alm;
            var consulta2 = from alm in Alumnos
                            where alm.Edad > 18
                            select alm;
            var consulta3 = from alm in Alumnos
                            orderby alm.Apellido 
                            select new { alm.Nombre, alm.Apellido };
            var consulta4 = from alm in Alumnos
                            orderby alm.Nombre, alm.Apellido descending
                            select alm;
            var consulta5 = from almu in Alumnos
                            group almu by almu.Edad into edad
                            select edad;
            var consulta7 = from almu in Alumnos
                            group almu by almu.Edad into edad
                            select new { Edad = edad.Key, cantidad = edad.Count() };
            foreach(var grupoedad in consulta7)
            { Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.cantidad); }
            foreach (var Grupoedades in consulta5)
            {
                Console.WriteLine(Grupoedades.Key);
                foreach(Persona alumno in Grupoedades)
                {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellido);
                }
            }
            foreach (var alumno in consulta)
            {
                Console.WriteLine(alumno.Nombre);
            }
            Console.ReadKey();
        }
    }
}
