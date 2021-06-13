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
using System.IO;

namespace FrmOrdenProduccion
{
    public partial class FrmPrincipal : Form
    {
        private DateTime fechaProduccion;
        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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
            if (!(cmbTipo.SelectedItem is null))
            {
                if (cmbTipo.SelectedItem.ToString() == "Comprimido")
                {
                    Orden.Medicamento = new Comprimido(cmbNombre.SelectedItem.ToString(), txtCodigo.Text, 500, ((int)nudCantidad.Value), Comprimido.ETipoVenta.Recetado);

                    MessageBox.Show("Carga exitosa", "COMPRIMIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Orden.Medicamento = new Inyectable(cmbNombre.SelectedItem.ToString(), txtCodigo.Text, 200, ((int)nudCantidad.Value), 25.5f, Inyectable.EAplicacion.Intramuscular);
                    MessageBox.Show("Carga exitosa", "INYECTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbOrden.Text = $"Fecha de Produccion {dtpFecha.Value.ToShortDateString()}\n\n" + Orden.MostrarInformacion();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\Orden de Produccion.txt"))
                {
                    sw.WriteLine($"Fecha de Produccion {dtpFecha.Value.ToShortDateString()}\n\n" + Orden.MostrarInformacion());
                }
                using (StreamReader sr = new StreamReader(escritorio + @"\Orden de Produccion.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Se envió la orden al escritorio", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
