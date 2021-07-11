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
        bool flagImport = false;
        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

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

            try
            {
                using (StreamWriter sw = new StreamWriter(misDocumentos + @"\Orden para importar.txt"))
                {
                    sw.WriteLine($"Fecha de Produccion {dtpFecha.Value.ToShortDateString()}\n\nCOMPRIMIDO\nNombre: Omeprazol\nFecha de vencimiento: 10 / 3 / 2023\nCantidad: 14\nBlisters(2 unidades): 7\nDistribucion: Recetado\n\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFecha.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Fecha inválida. Se tomará la fecha actual.");
                    dtpFecha.Value = DateTime.Now;
                }

                if (!(cmbTipo.SelectedItem is null) && !(cmbNombre.SelectedItem is null) && cmbTipo.SelectedItem.ToString() == "Comprimido")
                {
                    Orden.Medicamento = new Comprimido(cmbNombre.SelectedItem.ToString(), 500, ((int)nudCantidad.Value), Comprimido.ETipoVenta.Recetado);
                    MessageBox.Show($"Carga exitosa de {cmbNombre.SelectedItem.ToString()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (!(cmbTipo.SelectedItem is null) && !(cmbNombre.SelectedItem is null) && cmbTipo.SelectedItem.ToString() == "Inyectable")
                {
                    Orden.Medicamento = new Inyectable(cmbNombre.SelectedItem.ToString(), 200, ((int)nudCantidad.Value), 25.5f, Inyectable.EAplicacion.Intramuscular);
                    MessageBox.Show($"Carga exitosa de {cmbNombre.SelectedItem.ToString()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se cargo ningun medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbOrden.Text += $"Fecha de Produccion {dtpFecha.Value.ToShortDateString()}\n\n" + Orden.MostrarInformacion();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\Orden de Produccion.txt"))
                {
                    sw.WriteLine(rtbOrden.Text);
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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Archivos fileManager = new Archivos();

            if (!flagImport)
            {
                try
                {
                    rtbOrden.Text += fileManager.LeerArchivoTexto(misDocumentos + "\\Orden para importar.txt");
                    flagImport = true;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Se produjo un error por el siguiente motivo:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ya realizó la importación de datos.");
            }
        }
    }
}
