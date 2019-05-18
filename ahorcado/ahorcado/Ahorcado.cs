using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    class Ahorcado
    {
        private static readonly string[] Palabras = {"Computacion", "Español", "Eucalipto", "Orquidea" };
        private String PalabraAdivinar;
        private List<char> Letras;
        public int Estado { get; private set; }
        private String Guiones;
        private static Ahorcado Instancia;

        private Ahorcado()
        {
            Iniciar();
        }

        public void Iniciar()
        {
            Estado = 0;
            Letras = new List<char>();
            Random rnd = new Random();
            int indice = rnd.Next(3);
            PalabraAdivinar = Palabras[indice];
            Guiones = "";
            Guiones=Guiones.PadLeft(PalabraAdivinar.Count(), '_');
        }

        public String Buscar(char letra)
        {
            Letras.Add(letra);
            string aux = "";
            if(PalabraAdivinar.Contains(letra.ToString()))
            {
                for(int i=0;i<PalabraAdivinar.Count();i++)
                {
                    if(PalabraAdivinar[i]==letra)
                    {
                        aux += letra;
                    }
                    else
                    {
                        aux += Guiones[i];
                    }
                }
                Guiones = aux;
                return aux;
            }
            else
            {
                Estado++;
                return Guiones;
            }
         
        }

        public String BuscarPalabra(string palabra)
        {
            if (palabra == PalabraAdivinar)
                Guiones=PalabraAdivinar;
            else
                Estado++;
            return Guiones;
        }
        public static Ahorcado getInstancia()
        {
            if(Instancia==null)
            {
                Instancia = new Ahorcado();
            }
            return Instancia;
        }
    }
}
