using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1final
{
    class Registro
    {
        public string Placa { get; set; }
        public string TipoAuto { get; set; }
        public double Monto { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }

        /*public Registro(string placa,string tipo,double monto,string ingreso,string salida)
        {
            this.Placa = placa;
            this.TipoAuto = tipo;
            this.Monto = monto;
            this.HoraIngreso = ingreso;
            this.HoraSalida = salida;
        }*/
    }
}
