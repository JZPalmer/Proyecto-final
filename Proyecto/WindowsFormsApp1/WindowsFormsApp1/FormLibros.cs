using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoBiblio
{
    public partial class FormLibros : Form
    {
        private Conexion Conexiones = new Conexion();

        public FormLibros()
        {
            InitializeComponent();
            Tabla();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {

        }

        private void Tabla()
        {
            string query = "Select * from Libro";

            using (SqlConnection conn = Conexiones.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Boton_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Boton_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
                return;
            }

            string query = "Delete from Libro where ISBN = @ISBN";

            using (SqlConnection conn = Conexiones.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ISBN", textBox7.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro eliminado correctamente");
                    Tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el libro: " + ex.Message);
                }
            }
        }

        private void Boton_agregar_Click(object sender, EventArgs e)
        {
            int year;
            if (!int.TryParse(textBox2.Text, out year))
            {
                MessageBox.Show("Por favor, ingrese un año de publicación válido.");
                return;
            }

            int numeroCopia;
            if (!int.TryParse(textBox1.Text, out numeroCopia))
            {
                MessageBox.Show("Por favor, ingrese un número de copia válido.");
                return;
            }

            string query = "Insert Into Libro (ISBN, Titulo, Autor, Editorial, AñoPublicacion, Genero, NumeroCopia) " +
                "values (@ISBN, @Titulo, @Autor, @Editorial, @AñoPublicacion, @Genero, @NumeroCopia)";

            using (SqlConnection conn = Conexiones.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ISBN", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Titulo", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Autor", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Editorial", textBox5.Text);
                    cmd.Parameters.AddWithValue("@AñoPublicacion", year);
                    cmd.Parameters.AddWithValue("@Genero", textBox4.Text);
                    cmd.Parameters.AddWithValue("@NumeroCopia", numeroCopia);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro agregado exitosamente");
                    Tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro: " + ex.Message);
                }
            }
        }

        private void Boton_Actualizar_Click(object sender, EventArgs e)
        {
            int year;
            if (!int.TryParse(textBox2.Text, out year))
            {
                MessageBox.Show("Por favor, ingrese un año de publicación válido.");
                return;
            }

            int numeroCopia;
            if (!int.TryParse(textBox1.Text, out numeroCopia))
            {
                MessageBox.Show("Por favor, ingrese un número de copia válido.");
                return;
            }

            string query = "Update Libro set Titulo = @Titulo, Autor = @Autor, Editorial = @Editorial, " +
                "AñoPublicacion = @AñoPublicacion, Genero = @Genero, NumeroCopia = @NumeroCopia where ISBN = @ISBN";

            using (SqlConnection conn = Conexiones.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ISBN", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Titulo", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Autor", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Editorial", textBox5.Text);
                    cmd.Parameters.AddWithValue("@AñoPublicacion", year);
                    cmd.Parameters.AddWithValue("@Genero", textBox4.Text);
                    cmd.Parameters.AddWithValue("@NumeroCopia", numeroCopia);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro actualizado correctamente");
                    Tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el libro: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox7.Text = row.Cells["ISBN"].Value.ToString();
                textBox6.Text = row.Cells["Titulo"].Value.ToString();
                textBox3.Text = row.Cells["Autor"].Value.ToString();
                textBox5.Text = row.Cells["Editorial"].Value.ToString();
                textBox2.Text = row.Cells["AñoPublicacion"].Value.ToString();
                textBox4.Text = row.Cells["Genero"].Value.ToString();
                textBox1.Text = row.Cells["NumeroCopia"].Value.ToString();
            }
        }
    }
}
