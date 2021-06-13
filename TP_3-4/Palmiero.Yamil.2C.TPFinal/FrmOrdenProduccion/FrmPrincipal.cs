using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace FrmOrdenProduccion
{
    public partial class FrmPrincipal : Form
    {
        private DateTime fechaProduccion;
        private Orden ordenProduccion = new Orden();
        private Inyectable inyectable;
        private Comprimido comprimido;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();

            cmbTipo.Items.Add("Comprimido");
            cmbTipo.Items.Add("Inyectable");

            cmbNombre.Items.Add("Omeprazol");
            cmbNombre.Items.Add("Ibuprofeno");
            cmbNombre.Items.Add("Paracetamol");

            cmbNombre.Items.Add("Buscapina");
            cmbNombre.Items.Add("Corticoides");

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ordenProduccion.Cargar(cmbNombre.Text, txtCodigo.Text, 10, -25.5f, Inyectable.EAplicacion.Endovenosa);
            MessageBox.Show("Carga exitosa", "Carga de medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.rtbOrden.Text = inyectable.ToString();
        }
    }
}
