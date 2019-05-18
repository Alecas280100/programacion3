using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnempezar_Click(object sender, EventArgs e)
        {
            Ahorcado.getInstancia().Iniciar();
            lblrespuesta.Text = "";
            
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
            txtPalabra.Text = "";
        }

        private void txtrespuesta_TextChanged(object sender, EventArgs e)
        {
            txtPalabra.Text = "";
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = Ahorcado.getInstancia().Buscar(txtrespuesta.Text[0]);
            switch(Ahorcado.getInstancia().Estado)
            {
                case 0:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\1.png");
                    break;
                case 1:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\2.png");
                    break;
                case 2:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\3.png");
                    break;
                case 3:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\4.png");
                    break;
                case 4:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\5.png");
                    break;
                case 5:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\6.png");
                    break;
                case 6:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\7.png");
                    break;
                case 7:
                    pbimagen.Image = Image.FromFile("C: \\Users\\Estudiante\\programacion3\\8.png");
                    MessageBox.Show("Ha perdido");
                    break;

            }
        }

        private void btnenviarpalabra_Click(object sender, EventArgs e)
        {

        }
    }
}
