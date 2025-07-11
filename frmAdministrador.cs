using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            cmbRol.SelectedIndex = -1;

            switch (cmbUsuarios.SelectedIndex)
            {
                case -1:
                case 0:
                    break;
                case 1:
                    txtNombre.Text = "María";
                    txtApellido.Text = "Pérez";
                    txtEdad.Text = "32";
                    cmbRol.SelectedItem = "Admin";
                    break;
                case 2:
                    txtNombre.Text = "Juan";
                    txtApellido.Text = "López";
                    txtEdad.Text = "28";
                    cmbRol.SelectedItem = "Usuario";
                    break;
                case 3:
                    txtNombre.Text = "Ana";
                    txtApellido.Text = "Gómez";
                    txtEdad.Text = "24";
                    cmbRol.SelectedItem = "Usuario";
                    break;
                case 4:
                    txtNombre.Text = "Carlos";
                    txtApellido.Text = "Díaz";
                    txtEdad.Text = "35";
                    cmbRol.SelectedItem = "Admin";
                    break;
                default:
                    break;
            }

            btnModificar.Enabled = (cmbUsuarios.SelectedIndex > 0);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("Usuario eliminado correctamente (Simulación)");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            cmbRol.Enabled = true;

            btnModificar.Visible = false;
            btnGuardarModificar.Visible = true;
            btnCancelarModificar.Visible = true;
            btnGuardarModificar.Enabled = true;
            btnCancelarModificar.Enabled = true;

            btnAltaUsuario.Visible = false;
            btnAltaUsuario.Enabled = false;
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUsuarios.Text) || cmbUsuarios.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario válido.");
                cmbUsuarios.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido.");
                txtApellido.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtEdad.Text))
            {
                if (!int.TryParse(txtEdad.Text, out int edad) || edad < 1 || edad > 120)
                {
                    MessageBox.Show("La edad debe ser un número válido entre 1 y 120.");
                    txtEdad.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(cmbRol.Text))
            {
                MessageBox.Show("Debe ingresar el rol.");
                cmbRol.Focus();
                return;
            }

            if (cmbRol.Text != "Admin" && cmbRol.Text != "Usuario")
            {
                MessageBox.Show("El rol debe ser 'Admin' o 'Usuario'.");
                cmbRol.Focus();
                return;
            }

            MessageBox.Show("Cambios guardados correctamente (Simulación)");

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cmbRol.Enabled = false;

            btnGuardarModificar.Visible = false;
            btnCancelarModificar.Visible = false;
            btnModificar.Visible = true;
            btnAltaUsuario.Visible = true;
            btnAltaUsuario.Enabled = true;
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            int index = cmbUsuarios.SelectedIndex;
            cmbUsuarios.SelectedIndex = 0;
            cmbUsuarios.SelectedIndex = index;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cmbRol.Enabled = false;

            btnGuardarModificar.Visible = false;
            btnCancelarModificar.Visible = false;
            btnModificar.Visible = true;
            btnAltaUsuario.Visible = true;
            btnAltaUsuario.Enabled = true;
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();

            cmbUsuarios.SelectedIndex = -1; // no deshabilita el ComboBox de usuarios ya existentes, pero lo hace más intuitivo 
            cmbRol.SelectedIndex = -1;

            cmbUsuarios.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            cmbRol.Enabled = true;

            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnAltaUsuario.Enabled = false;

            btnGuardarAlta.Visible = true;
            btnCancelarAlta.Visible = true;
            btnGuardarAlta.Enabled = true;
            btnCancelarAlta.Enabled = true;
        }

        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUsuarios.Text) || cmbUsuarios.SelectedIndex == 0)
            {
                MessageBox.Show("El campo Usuario es obligatorio (por ejemplo: nombre.apellido).");
                cmbUsuarios.Focus();
                return;            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido.");
                txtApellido.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtEdad.Text))
            {
                bool edadValida = int.TryParse(txtEdad.Text, out int edad);
                if (!edadValida || edad < 0 || edad > 120)
                {
                    MessageBox.Show("La edad debe ser un número válido entre 0 y 120.");
                    txtEdad.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(cmbRol.Text))
            {
                MessageBox.Show("Debe ingresar el rol.");
                cmbRol.Focus();
                return;
            }

            MessageBox.Show("Usuario creado correctamente (Simulación)");

            cmbRol.Enabled = false;
            btnAltaUsuario.Enabled = true;
            btnCancelarAlta.PerformClick();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cmbRol.Enabled = false;

            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            cmbRol.SelectedIndex = -1;

            cmbUsuarios.Enabled = true;
            cmbUsuarios.SelectedIndex = 0;

            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardarAlta.Visible = false;
            btnCancelarAlta.Visible = false;
            btnAltaUsuario.Enabled = true;
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Usuario");
            cmbRol.SelectedIndex = -1;

            string[] usuarios = { "Seleccionar Usuario", "maria.perez", "juan.lopez", "ana.gomez", "carlos.diaz" };
            cmbUsuarios.DataSource = usuarios;
            cmbUsuarios.SelectedIndex = 0;

            cmbRol.Enabled = false;
        }
    }
}
