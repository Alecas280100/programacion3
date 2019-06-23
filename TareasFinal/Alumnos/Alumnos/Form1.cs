using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        alumno a;
        aula ala;
        string sexo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            ala = new aula();
            if (rbm.Checked)
            {
                sexo = "M";
            }
            else if(rbf.Checked)
            {
                sexo = "F";
            }
            a = new alumno(txtnombre.Text, sexo, int.Parse(txtedad.Text), cbcarrera.Text);
            ala.insertar(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                dataGridView1.DataSource= ala.GetVarones();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            dataGridView2.DataSource = ala.ListaAlumnos;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ala.eliminar(a);
        }
    }
}
