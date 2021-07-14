using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Yamil.Palmiero._2C.TPFinal
{
    public partial class FrmPrincipal : Form
    {
        private Laboratorio laboratorio = new Laboratorio();
        private Medicamento inyectable;
        private Medicamento comprimido;

        private string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();

            cmbTipo.Items.Add("Comprimido");
            cmbDroga.Items.Add("Omeprazol");
            cmbDroga.Items.Add("Ibuprofeno");
            cmbDroga.Items.Add("Paracetamol");

            cmbTipo.Items.Add("Inyectable");
            cmbDroga.Items.Add("Buscapina");
            cmbDroga.Items.Add("Corticoides");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbTipo.SelectedItem is null) && !(cmbDroga.SelectedItem is null) && cmbTipo.SelectedItem.ToString() == "Comprimido")
                {
                    comprimido = new Comprimido(cmbDroga.SelectedItem.ToString(), ETipo.VentaLibre, (int)nudCantidad.Value, Eunidad.Unidades);
                    MessageBox.Show($"Carga exitosa de {cmbDroga.SelectedItem.ToString()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        laboratorio.medicamentos.Add(comprimido);
                    }
                    catch (MedicamentoRepetidoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (!(cmbTipo.SelectedItem is null) && !(cmbDroga.SelectedItem is null) && cmbTipo.SelectedItem.ToString() == "Inyectable")
                {
                    inyectable = new Inyectable(cmbDroga.SelectedItem.ToString(), ETipo.VentaLibre, (int)nudCantidad.Value, Eunidad.Unidades);
                    MessageBox.Show($"Carga exitosa de {cmbDroga.SelectedItem.ToString()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        laboratorio.medicamentos.Add(inyectable);
                    }
                    catch (MedicamentoRepetidoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
            StringBuilder sb = new StringBuilder();

            foreach (Medicamento m in laboratorio.medicamentos)
            {
                try
                {
                    if (m is Inyectable)
                    {
                        sb.AppendLine("INYECTABLE");
                        sb.AppendLine(m.ToString());
                    }
                    else
                    {
                        sb.AppendLine("COMPRIMIDO");
                        sb.AppendLine(m.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            rtbInformacion.Text = sb.ToString();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                Laboratorio.Escribir(this.laboratorio, "ArchivoXml.xml");

                MessageBox.Show($"Se guardaron los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\Orden de Produccion.txt"))
                {
                    sw.WriteLine(rtbInformacion.Text);
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
