namespace WinFormsApp1
{
    partial class FrmRecuContra
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
            lblCorreoE = new Label();
            txtCorreoE = new TextBox();
            btnEnviar = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnValidar = new Button();
            lblNvaClave = new Label();
            txtClave = new TextBox();
            lblConfirClav = new Label();
            txtConfirClav = new TextBox();
            btnReestablecer = new Button();
            SuspendLayout();
            // 
            // lblCorreoE
            // 
            lblCorreoE.AutoSize = true;
            lblCorreoE.Location = new Point(47, 42);
            lblCorreoE.Name = "lblCorreoE";
            lblCorreoE.Size = new Size(108, 15);
            lblCorreoE.TabIndex = 0;
            lblCorreoE.Text = "Correo Electronico:";
            // 
            // txtCorreoE
            // 
            txtCorreoE.Location = new Point(191, 37);
            txtCorreoE.Margin = new Padding(3, 2, 3, 2);
            txtCorreoE.Name = "txtCorreoE";
            txtCorreoE.Size = new Size(230, 23);
            txtCorreoE.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(338, 74);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 22);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(56, 130);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(191, 124);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(230, 23);
            txtCodigo.TabIndex = 4;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(338, 162);
            btnValidar.Margin = new Padding(3, 2, 3, 2);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(82, 22);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblNvaClave
            // 
            lblNvaClave.AutoSize = true;
            lblNvaClave.Location = new Point(66, 226);
            lblNvaClave.Name = "lblNvaClave";
            lblNvaClave.Size = new Size(73, 15);
            lblNvaClave.TabIndex = 6;
            lblNvaClave.Text = "Nueva Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(190, 226);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(231, 23);
            txtClave.TabIndex = 7;
            // 
            // lblConfirClav
            // 
            lblConfirClav.AutoSize = true;
            lblConfirClav.Location = new Point(66, 271);
            lblConfirClav.Name = "lblConfirClav";
            lblConfirClav.Size = new Size(96, 15);
            lblConfirClav.TabIndex = 8;
            lblConfirClav.Text = "Confirmar Clave:";
            // 
            // txtConfirClav
            // 
            txtConfirClav.Location = new Point(191, 266);
            txtConfirClav.Margin = new Padding(3, 2, 3, 2);
            txtConfirClav.Name = "txtConfirClav";
            txtConfirClav.Size = new Size(230, 23);
            txtConfirClav.TabIndex = 9;
            // 
            // btnReestablecer
            // 
            btnReestablecer.Location = new Point(338, 304);
            btnReestablecer.Margin = new Padding(3, 2, 3, 2);
            btnReestablecer.Name = "btnReestablecer";
            btnReestablecer.Size = new Size(82, 22);
            btnReestablecer.TabIndex = 10;
            btnReestablecer.Text = "Reestablecer";
            btnReestablecer.UseVisualStyleBackColor = true;
            btnReestablecer.Click += btnReestablecer_Click;
            // 
            // FrmRecuContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 368);
            Controls.Add(btnReestablecer);
            Controls.Add(txtConfirClav);
            Controls.Add(lblConfirClav);
            Controls.Add(txtClave);
            Controls.Add(lblNvaClave);
            Controls.Add(btnValidar);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviar);
            Controls.Add(txtCorreoE);
            Controls.Add(lblCorreoE);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRecuContra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRecuContra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreoE;
        private TextBox txtCorreoE;
        private Button btnEnviar;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnValidar;
        private Label lblNvaClave;
        private TextBox txtClave;
        private Label lblConfirClav;
        private TextBox txtConfirClav;
        private Button btnReestablecer;
    }
}