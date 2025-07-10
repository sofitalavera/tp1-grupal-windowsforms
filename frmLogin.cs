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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }


            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar la Clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();
                return;
            }

            string usuario = txtUsuario.Text;
            string Clave = txtClave.Text;

            if (((usuario == "juan.lopez" || usuario == "ana.gomez") && Clave == "1234") ||
                ((usuario == "maria.perez" || usuario == "carlos.diaz") && Clave == "5678"))
            {
                if (usuario == "juan.lopez" || usuario == "ana.gomez")
                {
                    User frm = new User();
                    frm.Show();
                }
                else
                {
                    frmAdministrador frm = new frmAdministrador();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }

       
        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOlvideClave_Click(object sender, EventArgs e)
        {
            FrmRecuContra frm = new FrmRecuContra();
            frm.Show();
        }
    }
}
