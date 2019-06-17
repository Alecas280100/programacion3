using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraEconomica
{
    public partial class Form1 : Form
    {
        public int arriba = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            for(int i=0;i<int.Parse(txtingresar.Text);i++)
            {
                TextBox txt = new TextBox();
                txt.Top = arriba;
                arriba += 22;
                panltxt.Controls.Add(txt);
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double[] flujos = new double[int.Parse(txtingresar.Text)];
            int i = 0;
            foreach (Control control in panltxt.Controls)
                if (control.GetType().Name == "TextBox")
                {
                    flujos[i] = double.Parse(control.Text);
                    i++;
                }
            CalculadoraFinanciera cal = new CalculadoraFinanciera(int.Parse(txtingresar.Text),double.Parse(txttasa.Text));
            lblVAN.Text = cal.VAN(double.Parse(txtinversion.Text), flujos).ToString();
        }
    }
}
