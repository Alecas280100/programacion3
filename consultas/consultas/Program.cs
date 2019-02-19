using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] Alumnos = new Alumno[7];
            Alumnos[0] = new Alumno("Castro", 19, "Masculino");
            Alumnos[1] = new Alumno("La Torre", 18, "Masculino");
            Alumnos[2] = new Alumno("Adamczyk", 18, "Masculino");
            Alumnos[3] = new Alumno("Lopez", 19, "Femenino");
            Alumnos[4] = new Alumno("Guzman", 18, "Femenino");
            Alumnos[5] = new Alumno("Quiñones", 19, "Masculino");
            Alumnos[6] = new Alumno("Zarate", 19, "Masculino");

            var consulta1 = from alm in Alumnos
                            orderby alm.Apellido descending
                            select alm;

            var consulta2 = from alm in Alumnos
                            where alm.Edad == 18 && alm.Sexo == "Masculino"
                            select alm;
           
            var consulta3 = from alm in Alumnos
                            group alm by alm.Sexo into sexo
                            select sexo;
           
            var consulta4 = from almu in Alumnos
                            group almu by almu.Sexo into sexo
                            select new { Sexo =sexo.Key, cantidad = sexo.Count() };

            //var consulta5 = from almu in Alumnos
            //group almu by almu.Edad into edad
            //select new { Edad = edad.Key, promedio = edad.GetEnumerator() };
            //foreach (var grupoedad in consulta5)
            //{ Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.promedio); }
            Console.WriteLine("Consulta1:");
            foreach (var alumno in consulta1)
            {
                Console.WriteLine(alumno.Apellido);
            }
            Console.WriteLine("Consulta2:");
            foreach(var alumno in consulta2)
            {
                Console.WriteLine("{0} {1}", alumno.Edad, alumno.Sexo);
            }
            Console.WriteLine("Consulta3:");
            foreach (var Grupoedades in consulta3)
            {
                Console.WriteLine(Grupoedades.Key);
                foreach (Alumno alumno in Grupoedades)
                {
                    Console.WriteLine("{0} {1}", alumno.Apellido, alumno.Sexo);
                }
            }
            Console.WriteLine("Consulta4:");
            foreach (var grupoedad in consulta4)
            { Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.cantidad); }
            
           
            Console.ReadKey();
        }
    }
}
