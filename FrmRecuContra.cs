namespace WinFormsApp1
{
    public partial class FrmRecuContra : Form
    {
        public FrmRecuContra()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtCorreoE.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor ingrese Correo Electronico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (email == "user@gmail.com")
            {
                MessageBox.Show("Codigo Enviado al Correo Electronico.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Ingrese Correo un Correo valido.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string CodValid = txtCodigo.Text;
            if (CodValid == "soledad")
            {
                MessageBox.Show("Codigo exitoso.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor introdusca un Codigo valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            string Nueva = txtClave.Text;
            string Confirmacion = txtConfirClav.Text;
            if (string.IsNullOrEmpty(Nueva) || string.IsNullOrEmpty(Confirmacion))
            {
                MessageBox.Show("Por Favor Complete el Campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (Confirmacion == "Sole1234.")
            {
                MessageBox.Show("Su Contrasena se actualizo Correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("la Contrasena no coincide. Por favor,verifique que las contrasenas sean iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}