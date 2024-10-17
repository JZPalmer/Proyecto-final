using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblio
{
    public partial class Form1 : Form
    {
        // Constructor de la clase Form1, donde se inicializa el formulario principal.
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario.
        }

        // Evento que se dispara cuando se hace clic en el botón "Libros".
        private void Boton_Libros_Click(object sender, EventArgs e)
        {
            FormLibros formLibros = new FormLibros(); // Crea una nueva instancia del formulario de libros.
            formLibros.Show(); // Muestra el formulario de libros.
        }

        // Evento que se dispara cuando se hace clic en el botón "Clientes".
        private void Boton_Clientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente(); // Crea una nueva instancia del formulario de clientes.
            formCliente.Show(); // Muestra el formulario de clientes.
        }

        // Evento que se dispara cuando se hace clic en el botón "Reservas".
        private void Boton_Reserva_Click(object sender, EventArgs e)
        {
            FormReserva formReserva = new FormReserva(); // Crea una nueva instancia del formulario de reservas.
            formReserva.Show(); // Muestra el formulario de reservas.
        }

        // Evento que se dispara cuando se hace clic en el botón "Consultas y Reportes".
        private void Boton_Consultas_Click(object sender, EventArgs e)
        {
            FormConsultayReporte formConsultayReporte = new FormConsultayReporte(); // Crea una nueva instancia del formulario de consultas y reportes.
            formConsultayReporte.Show(); // Muestra el formulario de consultas y reportes.
        }

        // Evento que se dispara cuando se hace clic en el botón "Cierre", cierra el formulario principal.
        private void Boton_Cierre_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario principal.
        }

        // Evento que se dispara cuando el formulario principal se carga, aunque actualmente no tiene funcionalidad.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
