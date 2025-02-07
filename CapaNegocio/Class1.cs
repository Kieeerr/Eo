using CapaDatos;
using CapaEntidad;
using static CapaEntidad.Entidades;

namespace CapaNegocio
{
    
    
        public class ClienteNegocio
        {
            private ClienteDAO clienteDAO = new ClienteDAO();

            public List<Cliente> ObtenerClientes()
            {
                return new List<Cliente>(clienteDAO.ObtenerClientes());
            }

            public bool ObtenerClientePorID(Cliente cliente)
            {
                return clienteDAO.ObtenerClientePorID(cliente);
            }

        public bool RegistrarPrestamo(EntPrestamo prestamo)
        {
            return clienteDAO.RegistrarPrestamo(prestamo);
        }
        }
    
}

