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
        private string connectionString = "Server=R2D3;Database=FinanzasDB;Trusted_Connection=True;";

        public IEnumerable<Cliente> ObtenerClientes()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>("SELECT * FROM Cliente");
            }
        }

        public Cliente ObtenerClientePorID(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Cliente>(
                    "SELECT * FROM Cliente WHERE ID = @ID", new { ID = id });
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

