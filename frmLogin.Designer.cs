namespace WinFormsApp1
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnOlvideClave = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(38, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(181, 22);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(173, 27);
            txtUsuario.TabIndex = 1;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 12F);
            lblClave.ForeColor = SystemColors.ControlText;
            lblClave.Location = new Point(40, 67);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(55, 21);
            lblClave.TabIndex = 2;
            lblClave.Text = "CLAVE";
            lblClave.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 11F);
            txtClave.Location = new Point(181, 67);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Ingrese su clave";
            txtClave.Size = new Size(173, 27);
            txtClave.TabIndex = 3;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F);
            btnIngresar.Location = new Point(19, 142);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(121, 30);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(233, 142);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOlvideClave
            // 
            btnOlvideClave.FlatStyle = FlatStyle.System;
            btnOlvideClave.Font = new Font("Segoe UI", 11F);
            btnOlvideClave.Location = new Point(181, 103);
            btnOlvideClave.Margin = new Padding(3, 2, 3, 2);
            btnOlvideClave.Name = "btnOlvideClave";
            btnOlvideClave.Size = new Size(172, 24);
            btnOlvideClave.TabIndex = 6;
            btnOlvideClave.Text = "Olvidé mi clave";
            btnOlvideClave.UseVisualStyleBackColor = true;
            btnOlvideClave.Click += btnOlvideClave_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 194);
            Controls.Add(btnOlvideClave);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnOlvideClave;
    }
}
