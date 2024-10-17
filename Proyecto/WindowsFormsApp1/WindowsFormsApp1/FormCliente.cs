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
    public partial class FormCliente : Form
    {
        // Instancia de la clase Conexion, que maneja la conexión con la base de datos.
        private Conexion conexionDB = new Conexion();

        // Constructor del formulario, se llama al método Subir() para cargar los datos al iniciar.
        public FormCliente()
        {
            InitializeComponent();
            Subir();
        }

        // Método que carga los datos de la tabla "Usuario" en el DataGridView al abrir el formulario.
        private void Subir()
        {
            string query = "Select * from Usuario"; // Consulta SQL para seleccionar todos los usuarios.

            using (SqlConnection conn = conexionDB.Conectar()) // Abre la conexión con la base de datos.
            {
                SqlCommand cmd = new SqlCommand(query, conn); // Crea un comando SQL con la consulta.
                SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adaptador para rellenar la tabla de datos.
                DataTable dt = new DataTable(); // Crea una tabla en memoria para almacenar los resultados.
                da.Fill(dt); // Llena la tabla con los datos obtenidos.
                dataGridView1.DataSource = dt; // Asigna la tabla como fuente de datos del DataGridView.
            }
        }

        // Método que se ejecuta al cargar el formulario, pero actualmente está vacío.
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón "Agregar", inserta un nuevo usuario en la base de datos.
        private void Boton_agregar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para insertar un nuevo usuario con parámetros.
            string query = "Insert Into Usuario (Nombre, Apellido, Email, Telefono) VALUES (@Nombre, @Apellido, @Email, @Telefono)";

            using (SqlConnection conn = conexionDB.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn); // Crea el comando SQL con la consulta.
                    // Agrega los valores de los campos del formulario a los parámetros SQL.
                    cmd.Parameters.AddWithValue("@Nombre", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Apellido", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textBox1.Text);

                    cmd.ExecuteNonQuery(); // Ejecuta el comando (inserta los datos).
                    MessageBox.Show("Usuario agregado correctamente"); // Mensaje de éxito.
                    Subir(); // Recarga los datos del DataGridView.
                }
                catch (Exception ex) // Manejo de errores si la inserción falla.
                {
                    MessageBox.Show("Error al agregar el usuario: " + ex.Message); // Muestra el error.
                }
            }
        }

        string ID; // Variable para almacenar el ID del usuario seleccionado.

        // Evento del botón "Eliminar", elimina el usuario seleccionado de la base de datos.
        private void Boton_eliminar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para eliminar un usuario por su ID.
            string query = "Delete from Usuario where IdUsuario = @IdUsuario";

            using (SqlConnection conn = conexionDB.Conectar()) // Abre la conexión con la base de datos.
            {
                SqlCommand cmd = new SqlCommand(query, conn); // Crea el comando SQL.
                cmd.Parameters.AddWithValue("@IdUsuario", ID); // Asigna el valor del ID seleccionado.

                try
                {
                    cmd.ExecuteNonQuery(); // Ejecuta la eliminación.
                    MessageBox.Show("Usuario eliminado correctamente"); // Mensaje de éxito.
                    Subir(); // Recarga los datos del DataGridView.
                }
                catch (Exception ex) // Manejo de errores.
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message); // Muestra el error.
                }
            }
        }

        // Evento que se activa al hacer clic en una celda del DataGridView.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida.
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Obtiene la fila seleccionada.

                // Asigna los valores de la fila a los campos de texto y guarda el ID del usuario.
                ID = row.Cells[0].Value.ToString();
                textBox5.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
            }
        }

        // Evento del botón "Actualizar", actualiza los datos del usuario seleccionado.
        private void Boton_Actualizar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para actualizar los datos del usuario.
            string query = "Update Usuario set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono where IdUsuario = @IdUsuario";

            using (SqlConnection conn = conexionDB.Conectar()) // Abre la conexión con la base de datos.
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn); // Crea el comando SQL.
                    // Asigna los valores actualizados a los parámetros SQL.
                    cmd.Parameters.AddWithValue("@IdUsuario", ID);
                    cmd.Parameters.AddWithValue("@Nombre", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Apellido", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textBox1.Text);

                    cmd.ExecuteNonQuery(); // Ejecuta la actualización.
                    MessageBox.Show("Usuario actualizado correctamente"); // Mensaje de éxito.
                    Subir(); // Recarga los datos del DataGridView.
                }
                catch (Exception ex) // Manejo de errores.
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message); // Muestra el error.
                }
            }
        }

        // Evento del botón "Salir", cierra el formulario actual.
        private void Boton_salir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario.
        }
    }
}
