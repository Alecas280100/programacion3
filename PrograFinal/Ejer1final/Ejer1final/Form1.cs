using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejer1final
{
    public partial class Form1 : Form
    {

        List<Registro> parqueo = new List<Registro>();   
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Registro reg= new Registro { Placa = txtplaca.Text, TipoAuto = combotipo.Text, Monto = double.Parse(txtmonto.Text), HoraIngreso = txtingreso.Text, HoraSalida = txtsalida.Text };
            parqueo.Add(reg);      
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            var consulta1 = from mot in parqueo
                            where mot.TipoAuto == "moto"
                            select mot;
            foreach (var re in consulta1)
            {
                lblmostrar.Items.Add(re.TipoAuto);
            }
           
            var consulta2 = from tip in parqueo
                            group tip by tip.TipoAuto into tipos
                            select new { Tipos = tipos.Key, Cantidad = tipos.Count() };
            foreach (var modelo in consulta2)
            {
                lblmostrar.Items.Add(modelo.Tipos);
                lblmostrar.Items.Add(modelo.Cantidad);                
            }
          
            var consulta3 = from x in parqueo
                            where x.Monto > 10
                            select x;
            foreach (var re in consulta3)
            {
                lblmostrar.Items.Add(re.Placa);
                lblmostrar.Items.Add(re.TipoAuto);
                lblmostrar.Items.Add(re.HoraIngreso);
                lblmostrar.Items.Add(re.HoraSalida);
            }
        }
    }
}
