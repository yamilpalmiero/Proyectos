
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
            this.gpbProducir = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbDroga = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDroga = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.gpbProducir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(115, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
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
            // cmbDroga
            // 
            this.cmbDroga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDroga.FormattingEnabled = true;
            this.cmbDroga.Location = new System.Drawing.Point(90, 86);
            this.cmbDroga.Name = "cmbDroga";
            this.cmbDroga.Size = new System.Drawing.Size(157, 24);
            this.cmbDroga.TabIndex = 1;
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
            // lblDroga
            // 
            this.lblDroga.AutoSize = true;
            this.lblDroga.Location = new System.Drawing.Point(18, 89);
            this.lblDroga.Name = "lblDroga";
            this.lblDroga.Size = new System.Drawing.Size(47, 17);
            this.lblDroga.TabIndex = 3;
            this.lblDroga.Text = "Droga";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(31, 343);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(277, 75);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(31, 463);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(277, 75);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(31, 578);
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
            this.rtbInformacion.Size = new System.Drawing.Size(418, 495);
            this.rtbInformacion.TabIndex = 6;
            this.rtbInformacion.Text = "";
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
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(90, 136);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(157, 22);
            this.nudCantidad.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
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
    }
}

