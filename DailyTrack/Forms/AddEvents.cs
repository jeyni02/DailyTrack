using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTrack.Forms
{
    public partial class AddEvents : Form
    {
        private List<string> eventos = new List<string>();

        public AddEvents()
        {
            InitializeComponent();
            this.Load += AddEvents_Load;
        }

        private void AddEvents_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnAddEvents_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombreEvento = cbEventsName.Text;
            string horaEvento = tbhours.Text;
            string lugarEvento = tbPlace.Text;
            string descripcionEvento = tbhours.Text;
            DateTime fechaEvento = dtpDate.Value;

            // Crear una cadena que represente el evento
            string evento = $"Nombre: {nombreEvento},hora:{horaEvento}, lugar :{lugarEvento}" +
                $",Descripción: {descripcionEvento}, Fecha: {fechaEvento.ToShortDateString()}";

            // Agregar el evento a la lista
            eventos.Add(evento);

            // Mostrar el evento registrado en la consola
            foreach (string ev in eventos)
            {
                Console.WriteLine($"Evento registrado: {ev}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de agregar los eventos
            dgvShowData.Rows.Clear();

            // Asegurarse de que las columnas estén definidas
            if (dgvShowData.Columns.Count == 0)
            {
                dgvShowData.Columns.Add("Nombre", "Nombre");
                dgvShowData.Columns.Add("Hora", "Hora");
                dgvShowData.Columns.Add("Lugar", "Lugar");
                dgvShowData.Columns.Add("Descripción", "Descripción");
                dgvShowData.Columns.Add("Fecha", "Fecha");
            }

            // Agregar los eventos al DataGridView
            foreach (string evento in eventos)
            {
                // Dividir la cadena del evento en sus componentes
                string[] partesEvento = evento.Split(new string[] { ", " }, StringSplitOptions.None);
                if (partesEvento.Length >= 8)
                {
                    string nombre = partesEvento[0].Replace("Nombre: ", "");
                    string hora = partesEvento[1].Replace("Hora: ", "");
                    string lugar = partesEvento[2].Replace("Lugar: ", "");
                    string descripcion = partesEvento[3].Replace("Descripción: ", "");
                    string fecha = partesEvento[4].Replace("Fecha: ", "");

                    // Agregar una nueva fila al DataGridView
                    dgvShowData.Rows.Add(nombre, hora, lugar, descripcion, fecha);
                }
                else
                {
                    // Manejar el caso donde la cadena del evento no está en el formato esperado
                    MessageBox.Show("El formato del evento es incorrecto: " + evento);
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
