using Dapper;
using Microsoft.Data.SqlClient;
using CapaEntidad;
using static CapaEntidad.Entidades;

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
              string query = "SELECT * FROM Cliente WHERE ID = @ID";
              SqlCommand command = new SqlCommand(query, connection);
              command.Parameters.AddWithValue("@ID", cliente.ID);
              connection.Open();
              SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    cliente.NombreC = reader["Nombre_C"].ToString();
                    cliente.Sueldo = (decimal)reader["Sueldo"];
                    cliente.Telefono = reader["Telefono"].ToString();
                    cliente.ObjetoGarantia = reader["Garantia"].ToString();
                    cliente.Correo = reader["Correo"].ToString();
                     return true;

                }
                else
                {
                    return false;
                }


            }
        }

        public class moras

        {
            public static Moras GetMoraById(string connectionString, int id)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.QueryFirstOrDefault<Moras>(
                        "SELECT * FROM Moras WHERE ID = @ID", new { ID = id });
                }
            }

        }
           
       
        
        
    }
}

