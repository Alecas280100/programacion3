﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnobtenercoti_Click(object sender, EventArgs e)
        {
            lblmostrar.Text = Banco.getInstance().Obtenercotizacion(Convert.ToDouble(txtobtener.Text)).ToString();
        }

        private void btncolocarcoti_Click(object sender, EventArgs e)
        {
          
        }

        private void lblmostrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
