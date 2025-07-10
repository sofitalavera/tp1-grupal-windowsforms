namespace WinFormsApp1
{
    public partial class User : Form
    {
        DialogResult Resultado;
        public User()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Completar Nombre");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Completar Apellido");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Completar Edad");
                txtNombre.Focus();
                return;
            }
            MessageBox.Show("Sus Datos fueron Modificados Correctamente");
       
          
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.ReadOnly = false;
            txtEdad.ReadOnly = false;
            txtApellido.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {
            Resultado = MessageBox.Show("¿Esta seguro que desea realizar el cambio?", btnGuardar.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Resultado == DialogResult.OK)
            {
                MessageBox.Show("Los cambios se guardaron correctamente");
            }
            else
            {
                MessageBox.Show("Los cambios No se guardaron");
                return;
            }

        }
    }
}