using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms;
using CapaEntidad;
using System.Diagnostics.Metrics;




namespace CapaPresentacion
{

    public partial class Prestamoss : Form
    {
        public Prestamoss()
        {
            InitializeComponent();




        }
        EntPrestamo prestamo = new EntPrestamo();
        private void bttoncuota_Click(object sender, EventArgs e)
        {

            prestamo.Monto = Convert.ToDecimal(txtmonp.Text);
            prestamo.TiempoMeses = Convert.ToInt32(txtncuota.Text);

            txtporcent.Text = prestamo.CalcularInteres(prestamo.TiempoMeses).ToString();
            prestamo.CalcularTotales();
            guna2TextBox6.Text = prestamo.MontoCuota.ToString("N2");
            guna2TextBox3.Text = prestamo.Interes.ToString("N2");
            guna2TextBox7.Text = prestamo.MontoTotal.ToString("N2");

            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            // Asegurar que los datos del préstamo están correctamente asignados
            prestamo.Interes = Convert.ToDecimal(txtporcent.Text);
            prestamo.MontoTotal = Convert.ToDecimal(guna2TextBox7.Text);
            prestamo.Estado = "Pendiente"; // Definir un estado inicial
            prestamo.ClienteID = Entidades.Sesion.ID; // Verificar que `Sesion.ID` tenga un valor válido

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            bool resultado = clienteNegocio.RegistrarPrestamo(prestamo);

            if (resultado)
            {
                MessageBox.Show("Préstamo registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el préstamo.");
            }
        }
    }
}
