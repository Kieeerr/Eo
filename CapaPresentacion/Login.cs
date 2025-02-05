namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
            string[] datos = new string[2];
            datos[0] = IdTxt.Text;
            datos[1] = NombUsuTxt.Text;
            BaseFrame BaseFrame = new BaseFrame();
            Capital_form Capital_Form = new Capital_form();

            if (datos[0] == "9999" && datos[1] == "hanloscarsel")
            {
                BaseFrame.Show();

               this.Hide();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}
