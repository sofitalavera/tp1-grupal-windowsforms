namespace WinFormsApp1
{
    partial class frmAdministrador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbUsuarios = new ComboBox();
            lblUsuarios = new Label();
            lblRol = new Label();
            grpDatosPersonales = new GroupBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            lblEdad = new Label();
            btnModificar = new Button();
            btnGuardarModificar = new Button();
            btnCancelarModificar = new Button();
            btnAltaUsuario = new Button();
            btnEliminar = new Button();
            btnCancelarAlta = new Button();
            btnGuardarAlta = new Button();
            lblCamposObligatorios = new Label();
            cmbRol = new ComboBox();
            grpDatosPersonales.SuspendLayout();
            SuspendLayout();

            // cmbUsuarios
            cmbUsuarios.AutoCompleteMode = AutoCompleteMode.Append;
            cmbUsuarios.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUsuarios.FlatStyle = FlatStyle.Popup;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(180, 56);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(200, 28);
            cmbUsuarios.TabIndex = 10;
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged;

            // lblUsuarios
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(50, 60);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(68, 20);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Usuarios:";

            // lblRol
            lblRol.AutoSize = true;
            lblRol.Location = new Point(50, 310);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(54, 20);
            lblRol.TabIndex = 90;
            lblRol.Text = "Rol (*):";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;

            // grpDatosPersonales
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Location = new Point(50, 100);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(400, 180);
            grpDatosPersonales.TabIndex = 20;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";

            // txtNombre
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(130, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 40;

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 20);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "Nombre (*): ";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;

            // lblApellido
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 20);
            lblApellido.TabIndex = 50;
            lblApellido.Text = "Apellido (*):";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;

            // txtEdad
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(130, 120);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(200, 27);
            txtEdad.TabIndex = 80;

            // txtApellido
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(130, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 27);
            txtApellido.TabIndex = 60;

            // lblEdad
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(20, 125);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 70;
            lblEdad.Text = "Edad:";
            lblEdad.TextAlign = ContentAlignment.MiddleLeft;

            // btnModificar
            btnModificar.Location = new Point(530, 150);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 35);
            btnModificar.TabIndex = 120;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;

            // btnGuardarModificar
            btnGuardarModificar.Enabled = false;
            btnGuardarModificar.Location = new Point(660, 150);
            btnGuardarModificar.Name = "btnGuardarModificar";
            btnGuardarModificar.Size = new Size(120, 35);
            btnGuardarModificar.TabIndex = 130;
            btnGuardarModificar.Text = "Guardar";
            btnGuardarModificar.UseVisualStyleBackColor = true;
            btnGuardarModificar.Visible = false;
            btnGuardarModificar.Click += btnGuardarModificar_Click;

            // btnCancelarModificar
            btnCancelarModificar.Enabled = false;
            btnCancelarModificar.Location = new Point(660, 195);
            btnCancelarModificar.Name = "btnCancelarModificar";
            btnCancelarModificar.Size = new Size(120, 35);
            btnCancelarModificar.TabIndex = 140;
            btnCancelarModificar.Text = "Cancelar";
            btnCancelarModificar.UseVisualStyleBackColor = true;
            btnCancelarModificar.Visible = false;
            btnCancelarModificar.Click += btnCancelarModificar_Click;

            // btnAltaUsuario
            btnAltaUsuario.Location = new Point(530, 245);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(120, 35);
            btnAltaUsuario.TabIndex = 150;
            btnAltaUsuario.Text = "Alta Usuario";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;

            // btnEliminar
            btnEliminar.Location = new Point(530, 100);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 35);
            btnEliminar.TabIndex = 110;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;

            // btnCancelarAlta
            btnCancelarAlta.Enabled = false;
            btnCancelarAlta.Location = new Point(660, 290);
            btnCancelarAlta.Name = "btnCancelarAlta";
            btnCancelarAlta.Size = new Size(120, 35);
            btnCancelarAlta.TabIndex = 170;
            btnCancelarAlta.Text = "Cancelar";
            btnCancelarAlta.UseVisualStyleBackColor = true;
            btnCancelarAlta.Visible = false;
            btnCancelarAlta.Click += btnCancelarAlta_Click;

            // btnGuardarAlta
            btnGuardarAlta.Enabled = false;
            btnGuardarAlta.Location = new Point(660, 245);
            btnGuardarAlta.Name = "btnGuardarAlta";
            btnGuardarAlta.Size = new Size(120, 35);
            btnGuardarAlta.TabIndex = 160;
            btnGuardarAlta.Text = "Guardar";
            btnGuardarAlta.UseVisualStyleBackColor = true;
            btnGuardarAlta.Visible = false;
            btnGuardarAlta.Click += btnGuardarAlta_Click;

            // lblCamposObligatorios
            lblCamposObligatorios.AutoSize = true;
            lblCamposObligatorios.Font = new Font("Segoe UI", 9F);
            lblCamposObligatorios.ForeColor = Color.Red;
            lblCamposObligatorios.Location = new Point(50, 400);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new Size(133, 15);
            lblCamposObligatorios.TabIndex = 180;
            lblCamposObligatorios.Text = "(*) Campos obligatorios";

            // cmbRol
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Enabled = false;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(180, 306);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(200, 28);
            cmbRol.TabIndex = 100;

            // frmAdministrador
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmbRol);
            Controls.Add(lblCamposObligatorios);
            Controls.Add(btnCancelarAlta);
            Controls.Add(btnGuardarAlta);
            Controls.Add(btnEliminar);
            Controls.Add(btnAltaUsuario);
            Controls.Add(btnCancelarModificar);
            Controls.Add(btnGuardarModificar);
            Controls.Add(btnModificar);
            Controls.Add(grpDatosPersonales);
            Controls.Add(lblRol);
            Controls.Add(lblUsuarios);
            Controls.Add(cmbUsuarios);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdministrador";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += frmAdministrador_Load;
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuarios;
        private Label lblUsuarios;
        private Label lblRol;
        private GroupBox grpDatosPersonales;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private Label lblEdad;
        private Button btnModificar;
        private Button btnGuardarModificar;
        private Button btnCancelarModificar;
        private Button btnAltaUsuario;
        private Button btnEliminar;
        private Button btnCancelarAlta;
        private Button btnGuardarAlta;
        private Label lblCamposObligatorios;
        private ComboBox cmbRol;
    }
}