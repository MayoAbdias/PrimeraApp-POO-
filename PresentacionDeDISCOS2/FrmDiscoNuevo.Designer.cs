namespace PresentacionDeDISCOS2
{
    partial class FrmDiscoNuevo
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelFechaLanzamiento = new System.Windows.Forms.Label();
            this.labelCantidadCanciones = new System.Windows.Forms.Label();
            this.labelUrlImagenTapa = new System.Windows.Forms.Label();
            this.labelEstilo = new System.Windows.Forms.Label();
            this.labelTipoEdicion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxUrlImagenNueva = new System.Windows.Forms.TextBox();
            this.textBoxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.textBoxFechaLanzamiento = new System.Windows.Forms.TextBox();
            this.comboBoxEstilo = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoEdicion = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagenNueva = new System.Windows.Forms.PictureBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(94, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelFechaLanzamiento
            // 
            this.labelFechaLanzamiento.AutoSize = true;
            this.labelFechaLanzamiento.Location = new System.Drawing.Point(12, 51);
            this.labelFechaLanzamiento.Name = "labelFechaLanzamiento";
            this.labelFechaLanzamiento.Size = new System.Drawing.Size(115, 13);
            this.labelFechaLanzamiento.TabIndex = 1;
            this.labelFechaLanzamiento.Text = "Fecha de Lanzamiento";
            // 
            // labelCantidadCanciones
            // 
            this.labelCantidadCanciones.AutoSize = true;
            this.labelCantidadCanciones.Location = new System.Drawing.Point(10, 79);
            this.labelCantidadCanciones.Name = "labelCantidadCanciones";
            this.labelCantidadCanciones.Size = new System.Drawing.Size(117, 13);
            this.labelCantidadCanciones.TabIndex = 2;
            this.labelCantidadCanciones.Text = "Cantidad de Canciones";
            // 
            // labelUrlImagenTapa
            // 
            this.labelUrlImagenTapa.AutoSize = true;
            this.labelUrlImagenTapa.Location = new System.Drawing.Point(46, 108);
            this.labelUrlImagenTapa.Name = "labelUrlImagenTapa";
            this.labelUrlImagenTapa.Size = new System.Drawing.Size(80, 13);
            this.labelUrlImagenTapa.TabIndex = 3;
            this.labelUrlImagenTapa.Text = "UrlImagenTapa";
            // 
            // labelEstilo
            // 
            this.labelEstilo.AutoSize = true;
            this.labelEstilo.Location = new System.Drawing.Point(94, 136);
            this.labelEstilo.Name = "labelEstilo";
            this.labelEstilo.Size = new System.Drawing.Size(32, 13);
            this.labelEstilo.TabIndex = 4;
            this.labelEstilo.Text = "Estilo";
            // 
            // labelTipoEdicion
            // 
            this.labelTipoEdicion.AutoSize = true;
            this.labelTipoEdicion.Location = new System.Drawing.Point(46, 165);
            this.labelTipoEdicion.Name = "labelTipoEdicion";
            this.labelTipoEdicion.Size = new System.Drawing.Size(81, 13);
            this.labelTipoEdicion.TabIndex = 5;
            this.labelTipoEdicion.Text = "Tipo de Edicion";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(148, 23);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitulo.TabIndex = 6;
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // textBoxUrlImagenNueva
            // 
            this.textBoxUrlImagenNueva.Location = new System.Drawing.Point(148, 105);
            this.textBoxUrlImagenNueva.Name = "textBoxUrlImagenNueva";
            this.textBoxUrlImagenNueva.Size = new System.Drawing.Size(121, 20);
            this.textBoxUrlImagenNueva.TabIndex = 7;
            this.textBoxUrlImagenNueva.Leave += new System.EventHandler(this.textBoxUrlImagenNueva_Leave);
            // 
            // textBoxCantidadCanciones
            // 
            this.textBoxCantidadCanciones.Location = new System.Drawing.Point(148, 77);
            this.textBoxCantidadCanciones.Name = "textBoxCantidadCanciones";
            this.textBoxCantidadCanciones.Size = new System.Drawing.Size(121, 20);
            this.textBoxCantidadCanciones.TabIndex = 8;
            this.textBoxCantidadCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidadCanciones_KeyPress);
            this.textBoxCantidadCanciones.Leave += new System.EventHandler(this.textBoxCantidadCanciones_Leave);
            // 
            // textBoxFechaLanzamiento
            // 
            this.textBoxFechaLanzamiento.Location = new System.Drawing.Point(148, 51);
            this.textBoxFechaLanzamiento.Name = "textBoxFechaLanzamiento";
            this.textBoxFechaLanzamiento.Size = new System.Drawing.Size(121, 20);
            this.textBoxFechaLanzamiento.TabIndex = 9;
            this.textBoxFechaLanzamiento.Leave += new System.EventHandler(this.textBoxFechaLanzamiento_Leave);
            this.textBoxFechaLanzamiento.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFechaLanzamiento_Validating);
            // 
            // comboBoxEstilo
            // 
            this.comboBoxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstilo.FormattingEnabled = true;
            this.comboBoxEstilo.Location = new System.Drawing.Point(148, 136);
            this.comboBoxEstilo.Name = "comboBoxEstilo";
            this.comboBoxEstilo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstilo.TabIndex = 10;
            // 
            // comboBoxTipoEdicion
            // 
            this.comboBoxTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEdicion.FormattingEnabled = true;
            this.comboBoxTipoEdicion.Location = new System.Drawing.Point(148, 165);
            this.comboBoxTipoEdicion.Name = "comboBoxTipoEdicion";
            this.comboBoxTipoEdicion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoEdicion.TabIndex = 11;
            // 
            // pictureBoxImagenNueva
            // 
            this.pictureBoxImagenNueva.Location = new System.Drawing.Point(296, 23);
            this.pictureBoxImagenNueva.Name = "pictureBoxImagenNueva";
            this.pictureBoxImagenNueva.Size = new System.Drawing.Size(207, 181);
            this.pictureBoxImagenNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenNueva.TabIndex = 12;
            this.pictureBoxImagenNueva.TabStop = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(52, 220);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 13;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(163, 220);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmDiscoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 279);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.pictureBoxImagenNueva);
            this.Controls.Add(this.comboBoxTipoEdicion);
            this.Controls.Add(this.comboBoxEstilo);
            this.Controls.Add(this.textBoxFechaLanzamiento);
            this.Controls.Add(this.textBoxCantidadCanciones);
            this.Controls.Add(this.textBoxUrlImagenNueva);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTipoEdicion);
            this.Controls.Add(this.labelEstilo);
            this.Controls.Add(this.labelUrlImagenTapa);
            this.Controls.Add(this.labelCantidadCanciones);
            this.Controls.Add(this.labelFechaLanzamiento);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FrmDiscoNuevo";
            this.Text = "Disco Nuevo";
            this.Load += new System.EventHandler(this.FrmDiscoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelFechaLanzamiento;
        private System.Windows.Forms.Label labelCantidadCanciones;
        private System.Windows.Forms.Label labelUrlImagenTapa;
        private System.Windows.Forms.Label labelEstilo;
        private System.Windows.Forms.Label labelTipoEdicion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxUrlImagenNueva;
        private System.Windows.Forms.TextBox textBoxCantidadCanciones;
        private System.Windows.Forms.TextBox textBoxFechaLanzamiento;
        private System.Windows.Forms.ComboBox comboBoxEstilo;
        private System.Windows.Forms.ComboBox comboBoxTipoEdicion;
        private System.Windows.Forms.PictureBox pictureBoxImagenNueva;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}