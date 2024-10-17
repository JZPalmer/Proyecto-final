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

namespace ProyectoBiblio
{
    public partial class FormConsultayReporte : Form
    {

        private Conexion conexionDB = new Conexion ();
        public FormConsultayReporte()
        {
            InitializeComponent();
            Libros();
            Mostrar();
            LibrosReservados();
            ClientessReservados();


        }

        private void Libros()
        {
            string query = "Select distinct Genero from Libro";

            using (SqlConnection conn = conexionDB.Conectar())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Genero";
                    comboBox1.ValueMember = "Genero";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar libros: " + ex.Message);
                }
            }
        }


        private void Mostrar()
        {
            string query = "Select * from Libro where Genero = @Genero and NumeroCopia>0 ";

            using (SqlConnection conn = conexionDB.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Genero", comboBox1.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                try
                {

                }
                catch (Exception)
                {
                    MessageBox.Show("Primero debe existir libros y clientes: ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultayReporte_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void LibrosReservados()
        {
            string query = "Select L.ISBN, L.Titulo, L.Autor, L.Genero, COUNT(R.ISBN) AS TotalReserva from Libro L JOIN Reserva R ON L.ISBN = R.ISBN GROUP BY L.ISBN, L.Titulo, L.Autor, L.Genero ORDER BY TotalReserva DESC";

            using (SqlConnection conn = conexionDB.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void ClientessReservados()
        {
            string query = "Select C.IdUsuario, C.Nombre, C.Apellido, C.Email from Usuario C JOIN Reserva R on C.IdUsuario = R.IdUsuario GROUP BY C.IdUsuario, C.Nombre, C.Apellido, C.Email ORDER BY COUNT(R.IdUsuario) DESC";

            using (SqlConnection conn = conexionDB.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }
    }
}
