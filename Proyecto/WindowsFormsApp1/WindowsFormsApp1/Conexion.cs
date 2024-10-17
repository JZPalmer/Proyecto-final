using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoBiblio
{
    // Clase que maneja la conexión a la base de datos.
    public class Conexion
    {
        // Cadena de conexión que contiene los detalles para conectarse a la base de datos.
        private static string connectionString = "Server=localhost\\SQLEXPRESS; Initial Catalog=BilbiotecaProyecto; Integrated Security=True;";

        // Método para abrir una conexión con la base de datos.
        public SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(connectionString); // Crea una nueva conexión usando la cadena de conexión.
            try
            {
                conn.Open(); // Intenta abrir la conexión.
                return conn; // Si se abre exitosamente, devuelve la conexión.
            }
            catch (Exception ex) // Manejo de errores en caso de que la conexión falle.
            {
                // Lanza una nueva excepción con un mensaje personalizado si ocurre un error.
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
