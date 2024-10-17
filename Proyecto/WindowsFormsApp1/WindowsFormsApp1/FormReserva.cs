using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBiblio
{
    public partial class FormReserva : Form
    {
        // Instancia de la clase Conexion para manejar la conexión a la base de datos.
        private Conexion Conexiones = new Conexion();

        // Constructor del formulario que inicializa los componentes y carga datos de libros, usuarios y reservas.
        public FormReserva()
        {
            InitializeComponent();
            Libro();   // Cargar la lista de libros.
            Usuario(); // Cargar la lista de usuarios.
            Reserva(); // Cargar la tabla de reservas.
        }

        // Método que carga las reservas en el DataGridView.
        private void Reserva()
        {
            // Consulta SQL que une tablas de reservas, usuarios y libros.
            string query = "Select R.IdReserva, R.IdUsuario, (C.Nombre + '' + C.Apellido)as Usuario, R.ISBN, L.Titulo, R.FechaReserva, R.FechaRetorno from Reserva R join Usuario C on R.IdUsuario = C.IdUsuario join Libro L on R.ISBN = L.ISBN";

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                SqlCommand cmd = new SqlCommand(query, conn); // Crea un comando con la consulta.
                SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adaptador para ejecutar la consulta.
                DataTable dt = new DataTable(); // Crea una tabla para almacenar los datos.
                da.Fill(dt); // Llena la tabla con los datos obtenidos.
                dataGridView1.DataSource = dt; // Muestra los datos en el DataGridView.
            }
        }

        // Método que carga los libros en el ComboBox.
        private void Libro()
        {
            string query = "Select ISBN, Titulo from Libro"; // Consulta SQL para obtener los libros.

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn); // Adaptador para ejecutar la consulta.
                    DataTable dt = new DataTable(); // Crea una tabla para los datos.
                    da.Fill(dt); // Llena la tabla con los datos obtenidos.

                    // Asigna la lista de libros al ComboBox.
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "Titulo"; // Muestra el título del libro.
                    comboBox2.ValueMember = "ISBN"; // Usa el ISBN como valor seleccionado.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Libro: " + ex.Message); // Muestra el error si falla.
                }
            }
        }

        // Método que carga los usuarios en el ComboBox.
        private void Usuario()
        {
            string query = "Select IdUsuario, (Nombre + ' ' + Apellido) as Usuario from Usuario"; // Consulta SQL para obtener los usuarios.

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn); // Adaptador para ejecutar la consulta.
                    DataTable dt = new DataTable(); // Crea una tabla para los datos.
                    da.Fill(dt); // Llena la tabla con los datos obtenidos.

                    // Asigna la lista de usuarios al ComboBox.
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Usuario"; // Muestra el nombre completo del usuario.
                    comboBox1.ValueMember = "IdUsuario"; // Usa el ID del usuario como valor seleccionado.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar usuarios: " + ex.Message); // Muestra el error si falla.
                }
            }
        }

        // Evento que se ejecuta cuando el formulario se carga, pero actualmente está vacío.
        private void FormReserva_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón "Agregar", inserta una nueva reserva en la base de datos.
        private void Boton_agregar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para insertar una nueva reserva.
            string query = "Insert Into Reservas (IdUsuario, ISBN, FechaReserva, FechaRetorno) values (@IdUsuario, @ISBN, @FechaReserva, @FechaRetorno)";

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn); // Crea un comando SQL con la consulta.
                    // Asigna los valores seleccionados de los ComboBox y los DateTimePicker a los parámetros SQL.
                    cmd.Parameters.AddWithValue("@IdUsuario", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@ISBN", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@FechaReserva", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@FechaRetorno", dateTimePicker2.Value);

                    cmd.ExecuteNonQuery(); // Ejecuta la inserción.
                    MessageBox.Show("Reserva agregada correctamente"); // Muestra un mensaje de éxito.
                    Reserva(); // Recarga la tabla de reservas.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la reserva: " + ex.Message); // Muestra el error si falla.
                }
            }
        }

        // Evento del botón "Eliminar", elimina la reserva seleccionada de la base de datos.
        private void Boton_eliminar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para eliminar una reserva por su ID.
            string query = "Delete from Reserva where IdReserva = @IdReserva";

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                SqlCommand cmd = new SqlCommand(query, conn); // Crea un comando SQL con la consulta.
                // Asigna el valor del ID de la reserva seleccionada.
                cmd.Parameters.AddWithValue("@IdReserva", dataGridView1.CurrentRow.Cells["IdReserva"].Value);

                try
                {
                    cmd.ExecuteNonQuery(); // Ejecuta la eliminación.
                    MessageBox.Show("Reserva eliminada correctamente"); // Muestra un mensaje de éxito.
                    Reserva(); // Recarga la tabla de reservas.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la reserva: " + ex.Message); // Muestra el error si falla.
                }
            }
        }

        string ID; // Variable para almacenar el ID de la reserva seleccionada.

        // Evento del botón "Actualizar", actualiza los datos de la reserva seleccionada.
        private void Boton_Actualizar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para actualizar los datos de la reserva.
            string query = "Update Reserva set IdUsuario = @IdUsuario, ISBN = @ISBN, FechaReserva = @FechaReserva, FechaRetorno = @FechaRetorno WHERE IdReserva = @IdReserva";

            using (SqlConnection conn = Conexiones.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn); // Crea un comando SQL con la consulta.
                    // Asigna los valores actualizados a los parámetros SQL.
                    cmd.Parameters.AddWithValue("@IdReserva", ID);
                    cmd.Parameters.AddWithValue("@IdUsuario", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@ISBN", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@FechaReserva", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@FechaRetorno", dateTimePicker2.Value);

                    cmd.ExecuteNonQuery(); // Ejecuta la actualización.
                    MessageBox.Show("Reserva actualizada correctamente"); // Muestra un mensaje de éxito.
                    Reserva(); // Recarga la tabla de reservas.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la reserva: " + ex.Message); // Muestra el error si falla.
                }
            }
        }

        // Evento que se ejecuta al hacer clic en una celda del DataGridView, para rellenar los campos del formulario con los datos seleccionados.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se hizo clic en una fila válida.
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Obtiene la fila seleccionada.

                // Asigna los valores de la fila a los controles del formulario.
                ID = row.Cells["IdReserva"].Value.ToString();
                comboBox2.SelectedValue = row.Cells["IDUsuario"].Value;
                comboBox1.SelectedValue = row.Cells["ISBN"].Value;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["FechaReserva"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["FechaRetorno"].Value);
            }
        }

        // Evento del botón "Salir", cierra el formulario actual.
        private void Boton_salir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario.
        }
    }
}
