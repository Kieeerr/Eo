using Dapper;
using Microsoft.Data.SqlClient;
using CapaEntidad;
using static CapaEntidad.Entidades;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DatabaseHelper
    {

    }
    public class ClienteDAO
    {
        
        string connectionString = "Server=R2D3;Database=FinanzasDB;User Id=sa;Password=elsupermono1;TrustServerCertificate=True;";
        public IEnumerable<Cliente> ObtenerClientes()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>("SELECT * FROM Cliente");
            }
        }

        public bool ObtenerClientePorID(Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              string query = "SELECT * FROM Cliente WHERE Correo = @Correo";
              SqlCommand command = new SqlCommand(query, connection);
              command.Parameters.AddWithValue("@Correo", Sesion.Correo);
              connection.Open();
              SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    Sesion.ID = (int)reader["ID"];
                    cliente.NombreC = reader["Nombre_C"].ToString();
                    cliente.Sueldo = (decimal)reader["Sueldo"];
                    cliente.Telefono = reader["Telefono"].ToString();
                    cliente.ObjetoGarantia = reader["Garantia"].ToString();
                    Sesion.Correo = reader["Correo"].ToString();
                     return true;

                }
                else
                {
                    return false;
                }


                
            }
        }

        public bool RegistrarPrestamo(EntPrestamo prestamo)
        {
            if (prestamo.ClienteID == 0)
            {
                throw new Exception("ClienteID no puede ser 0 o vacío.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Prestamo
(ClienteID, Monto, TiempoMeses, Interes, MontoTotal, MontoAbonado, MontoPagado) 
VALUES (@ClienteID, @Monto, @TiempoMeses, @Interes, @MontoTotal, @MontoAbonado, @MontoPagado);
SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ClienteID", Sesion.ID);
                    command.Parameters.AddWithValue("@Monto", prestamo.Monto);
                    command.Parameters.AddWithValue("@TiempoMeses", prestamo.TiempoMeses);
                    command.Parameters.AddWithValue("@Interes", prestamo.Interes);
                    command.Parameters.AddWithValue("@MontoTotal", prestamo.MontoTotal);
                    command.Parameters.AddWithValue("@MontoAbonado", 0); // Inicializar en 0 ya que es un nuevo préstamo
                    command.Parameters.AddWithValue("@MontoPagado", 0); // Inicializar en 0 si aún no ha pagado nada
                    command.Parameters.AddWithValue("@MontoCuota", prestamo.MontoCuota);



                    connection.Open();
                    object result = command.ExecuteScalar();


                    if (result != null)
                    {
                        prestamo.PrestamoID = Convert.ToInt32(result);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el préstamo: {ex.Message}\n{ex.StackTrace}");
                return false;
            }


        }

    }
}


