
namespace Yamil.Palmiero._2C.TPFinal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbProducir = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDroga = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbDroga = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.rdbInsertar = new System.Windows.Forms.RadioButton();
            this.rdbConsultar = new System.Windows.Forms.RadioButton();
            this.rtbBD = new System.Windows.Forms.RichTextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.timHoraActual = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.gpbProducir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gpbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbProducir
            // 
            this.gpbProducir.Controls.Add(this.nudCantidad);
            this.gpbProducir.Controls.Add(this.lblCantidad);
            this.gpbProducir.Controls.Add(this.lblDroga);
            this.gpbProducir.Controls.Add(this.lblTipo);
            this.gpbProducir.Controls.Add(this.cmbDroga);
            this.gpbProducir.Controls.Add(this.cmbTipo);
            this.gpbProducir.Location = new System.Drawing.Point(31, 103);
            this.gpbProducir.Name = "gpbProducir";
            this.gpbProducir.Size = new System.Drawing.Size(278, 176);
            this.gpbProducir.TabIndex = 0;
            this.gpbProducir.TabStop = false;
            this.gpbProducir.Text = "Producir";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(90, 136);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(157, 22);
            this.nudCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(18, 136);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDroga
            // 
            this.lblDroga.AutoSize = true;
            this.lblDroga.Location = new System.Drawing.Point(18, 89);
            this.lblDroga.Name = "lblDroga";
            this.lblDroga.Size = new System.Drawing.Size(47, 17);
            this.lblDroga.TabIndex = 3;
            this.lblDroga.Text = "Droga";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(18, 45);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbDroga
            // 
            this.cmbDroga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDroga.FormattingEnabled = true;
            this.cmbDroga.Location = new System.Drawing.Point(90, 86);
            this.cmbDroga.Name = "cmbDroga";
            this.cmbDroga.Size = new System.Drawing.Size(157, 24);
            this.cmbDroga.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(90, 42);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(157, 24);
            this.cmbTipo.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(157, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(32, 285);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(277, 75);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(32, 366);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(277, 75);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(31, 447);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(277, 75);
            this.btnSerializar.TabIndex = 4;
            this.btnSerializar.Text = "Serializar a Xml";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(344, 578);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(418, 75);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar Orden";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(344, 42);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.Size = new System.Drawing.Size(418, 263);
            this.rtbInformacion.TabIndex = 6;
            this.rtbInformacion.Text = "";
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Location = new System.Drawing.Point(0, 50);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(278, 60);
            this.btnBaseDeDatos.TabIndex = 7;
            this.btnBaseDeDatos.Text = "Base de Datos";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnBaseDeDatos.Click += new System.EventHandler(this.btnBaseDeDatos_Click);
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Controls.Add(this.rdbInsertar);
            this.gpbOpciones.Controls.Add(this.rdbConsultar);
            this.gpbOpciones.Controls.Add(this.btnBaseDeDatos);
            this.gpbOpciones.Location = new System.Drawing.Point(31, 543);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(290, 110);
            this.gpbOpciones.TabIndex = 8;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Opciones";
            // 
            // rdbInsertar
            // 
            this.rdbInsertar.AutoSize = true;
            this.rdbInsertar.Location = new System.Drawing.Point(122, 23);
            this.rdbInsertar.Name = "rdbInsertar";
            this.rdbInsertar.Size = new System.Drawing.Size(77, 21);
            this.rdbInsertar.TabIndex = 9;
            this.rdbInsertar.Text = "Insertar";
            this.rdbInsertar.UseVisualStyleBackColor = true;
            // 
            // rdbConsultar
            // 
            this.rdbConsultar.AutoSize = true;
            this.rdbConsultar.Checked = true;
            this.rdbConsultar.Location = new System.Drawing.Point(6, 23);
            this.rdbConsultar.Name = "rdbConsultar";
            this.rdbConsultar.Size = new System.Drawing.Size(89, 21);
            this.rdbConsultar.TabIndex = 8;
            this.rdbConsultar.TabStop = true;
            this.rdbConsultar.Text = "Consultar";
            this.rdbConsultar.UseVisualStyleBackColor = true;
            // 
            // rtbBD
            // 
            this.rtbBD.Location = new System.Drawing.Point(344, 311);
            this.rtbBD.Name = "rtbBD";
            this.rtbBD.Size = new System.Drawing.Size(418, 263);
            this.rtbBD.TabIndex = 9;
            this.rtbBD.Text = "";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Yamil.Palmiero._2C.TPFinal.Properties.Resources.farmacia;
            this.ptbLogo.Location = new System.Drawing.Point(37, 27);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(81, 60);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 10;
            this.ptbLogo.TabStop = false;
            // 
            // timHoraActual
            // 
            this.timHoraActual.Enabled = true;
            this.timHoraActual.Interval = 1000;
            this.timHoraActual.Tick += new System.EventHandler(this.timHoraActual_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(191, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(39, 17);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.rtbBD);
            this.Controls.Add(this.gpbOpciones);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gpbProducir);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Produccion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gpbProducir.ResumeLayout(false);
            this.gpbProducir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gpbOpciones.ResumeLayout(false);
            this.gpbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbProducir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDroga;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbDroga;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnBaseDeDatos;
        private System.Windows.Forms.GroupBox gpbOpciones;
        private System.Windows.Forms.RadioButton rdbInsertar;
        private System.Windows.Forms.RadioButton rdbConsultar;
        private System.Windows.Forms.RichTextBox rtbBD;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Timer timHoraActual;
        private System.Windows.Forms.Label lblHora;
    }
}

