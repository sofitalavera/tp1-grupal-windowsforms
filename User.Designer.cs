namespace WinFormsApp1
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBxDatosPersonales = new GroupBox();
            btnModificar = new Button();
            txtEdad = new TextBox();
            LblEdad = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            grpBxDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxDatosPersonales
            // 
            grpBxDatosPersonales.Controls.Add(btnModificar);
            grpBxDatosPersonales.Controls.Add(txtEdad);
            grpBxDatosPersonales.Controls.Add(LblEdad);
            grpBxDatosPersonales.Controls.Add(txtApellido);
            grpBxDatosPersonales.Controls.Add(lblApellido);
            grpBxDatosPersonales.Controls.Add(txtNombre);
            grpBxDatosPersonales.Controls.Add(lblNombre);
            grpBxDatosPersonales.Location = new Point(25, 63);
            grpBxDatosPersonales.Name = "grpBxDatosPersonales";
            grpBxDatosPersonales.Size = new Size(338, 207);
            grpBxDatosPersonales.TabIndex = 2;
            grpBxDatosPersonales.TabStop = false;
            grpBxDatosPersonales.Text = "Datos Personales";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(155, 149);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(121, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(81, 107);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(196, 23);
            txtEdad.TabIndex = 5;
            txtEdad.Text = "54";
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // LblEdad
            // 
            LblEdad.AutoSize = true;
            LblEdad.Location = new Point(10, 110);
            LblEdad.Name = "LblEdad";
            LblEdad.Size = new Size(36, 15);
            LblEdad.TabIndex = 4;
            LblEdad.Text = "Edad:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(80, 72);
            txtApellido.MaxLength = 15;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(196, 23);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "Gomez";
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(9, 75);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(80, 37);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Ana";
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 288);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 325);
            Controls.Add(btnGuardar);
            Controls.Add(grpBxDatosPersonales);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            grpBxDatosPersonales.ResumeLayout(false);
            grpBxDatosPersonales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBxDatosPersonales;
        private Label lblNombre;
        private TextBox txtEdad;
        private Label LblEdad;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Button btnModificar;
        private Button btnGuardar;
    }
}
