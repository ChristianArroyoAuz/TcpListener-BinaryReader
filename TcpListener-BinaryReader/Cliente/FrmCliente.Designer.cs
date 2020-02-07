namespace Cliente
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.grbServidor = new System.Windows.Forms.GroupBox();
            this.txtDireccionServidor = new System.Windows.Forms.TextBox();
            this.lblNombreServidor = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lsbInfo = new System.Windows.Forms.ListBox();
            this.grbDatos.SuspendLayout();
            this.grbServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(486, 108);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtSalario);
            this.grbDatos.Controls.Add(this.lblSalario);
            this.grbDatos.Controls.Add(this.txtSexo);
            this.grbDatos.Controls.Add(this.lblSexo);
            this.grbDatos.Controls.Add(this.txtEdad);
            this.grbDatos.Controls.Add(this.lblEdad);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Location = new System.Drawing.Point(12, 23);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(311, 121);
            this.grbDatos.TabIndex = 2;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos para el Registro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(71, 59);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(69, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(18, 62);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad:";
            // 
            // txtSexo
            // 
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Location = new System.Drawing.Point(236, 59);
            this.txtSexo.MaxLength = 1;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(69, 20);
            this.txtSexo.TabIndex = 9;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(183, 62);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(71, 85);
            this.txtSalario.MaxLength = 5;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(111, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(18, 88);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 10;
            this.lblSalario.Text = "Salario:";
            // 
            // grbServidor
            // 
            this.grbServidor.Controls.Add(this.txtDireccionServidor);
            this.grbServidor.Controls.Add(this.lblNombreServidor);
            this.grbServidor.Location = new System.Drawing.Point(331, 23);
            this.grbServidor.Name = "grbServidor";
            this.grbServidor.Size = new System.Drawing.Size(311, 75);
            this.grbServidor.TabIndex = 3;
            this.grbServidor.TabStop = false;
            this.grbServidor.Text = "Información del Servidor:";
            // 
            // txtDireccionServidor
            // 
            this.txtDireccionServidor.Location = new System.Drawing.Point(95, 18);
            this.txtDireccionServidor.MaxLength = 400;
            this.txtDireccionServidor.Name = "txtDireccionServidor";
            this.txtDireccionServidor.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionServidor.TabIndex = 15;
            // 
            // lblNombreServidor
            // 
            this.lblNombreServidor.AutoSize = true;
            this.lblNombreServidor.Location = new System.Drawing.Point(21, 21);
            this.lblNombreServidor.Name = "lblNombreServidor";
            this.lblNombreServidor.Size = new System.Drawing.Size(68, 13);
            this.lblNombreServidor.TabIndex = 14;
            this.lblNombreServidor.Text = "Dirección IP:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(567, 108);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lsbInfo
            // 
            this.lsbInfo.FormattingEnabled = true;
            this.lsbInfo.Location = new System.Drawing.Point(12, 155);
            this.lsbInfo.Name = "lsbInfo";
            this.lsbInfo.Size = new System.Drawing.Size(630, 95);
            this.lsbInfo.TabIndex = 5;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 262);
            this.Controls.Add(this.lsbInfo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grbServidor);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnConectar);
            this.Name = "FrmCliente";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbServidor.ResumeLayout(false);
            this.grbServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox grbServidor;
        private System.Windows.Forms.TextBox txtDireccionServidor;
        private System.Windows.Forms.Label lblNombreServidor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lsbInfo;
    }
}

