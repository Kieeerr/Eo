using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Forms;
using CapaDatos;
using static CapaEntidad.Entidades;

namespace CapaPresentacion
{
    public partial class Capital_form : Form
    {

        public Capital_form()
        {
            InitializeComponent();
            
        }


        private ClienteNegocio ClienteNegocio = new ClienteNegocio();
        Cliente cliente = new Cliente();

       
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado =  new Cliente();
            bool result = ClienteNegocio.ObtenerClientePorID(clienteSeleccionado);
            if (result)
            {
                
                txtNombre.Text = clienteSeleccionado.NombreC;
                txtSueldo.Text = clienteSeleccionado.Sueldo.ToString();
                txtCorreo.Text = Sesion.Correo;
                txtTelefono.Text = clienteSeleccionado.Telefono;
                txtGarantia.Text = clienteSeleccionado.ObjetoGarantia;
            }
            else
            {
                MessageBox.Show("No se han encontrado datos con el id ingresado");
            }



        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
