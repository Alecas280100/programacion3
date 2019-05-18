using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Banco
    {
        private static Banco Instancia;//Singleton
        private Double Cotizacion;

       private Banco()
        {
            
        }
        public static Banco getInstance()//Singleton
        {
            if (Instancia == null)
                Instancia = new Banco();

            return Instancia;
        }
        public Double Obtenercotizacion(double coti)
        {
            Cotizacion = coti;
            return Cotizacion;
            
        }
        public Double Colocarcotizacion(double coti)
        {
            Cotizacion = coti;
            return Cotizacion;
        }
    }
}
