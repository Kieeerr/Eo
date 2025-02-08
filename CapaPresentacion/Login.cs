using Microsoft.Data.SqlClient;
using static CapaEntidad.Entidades;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "Server=R2D3;Database=FinanzasDB;User Id=sa;Password=elsupermono1;TrustServerCertificate=True;";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string correo = IdTxt.Text.Trim();
            string nombreUsuario = NombUsuTxt.Text.Trim();

            if (ValidarUsuario(correo, nombreUsuario))
            {
                Sesion.Correo = correo;

                BaseFrame baseFrame = new BaseFrame();
                baseFrame.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();

        }



        private bool ValidarUsuario(string correo, string nombreUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Cliente WHERE Correo = @Correo AND Nombre_C = @Nombre_C";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Nombre_C", nombreUsuario);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}
