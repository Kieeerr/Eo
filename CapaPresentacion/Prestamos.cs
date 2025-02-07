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
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            bool resultado = clienteNegocio.RegistrarPrestamo(prestamo);
            if (resultado)
            {
                MessageBox.Show("GOD");
            }
            else
            {
                MessageBox.Show("F");

            }
        }
    }
}
