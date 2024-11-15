using DailyTrack.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTrack
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Administration nuevoFormulario = new Administration();

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void btnEstudent_Click(object sender, EventArgs e)
        {
            
            Estudent nuevoFormulario = new Estudent();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
