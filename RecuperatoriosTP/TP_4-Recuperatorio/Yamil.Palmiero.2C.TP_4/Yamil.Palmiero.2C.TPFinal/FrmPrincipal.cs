using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public delegate void DelegadoAviso(string mensaje);

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
                    comprimido = new Comprimido(cmbDroga.SelectedItem.ToString(), cmbTipo.SelectedItem.ToString(), (int)nudCantidad.Value, Eunidad.Unidades);
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
                    inyectable = new Inyectable(cmbDroga.SelectedItem.ToString(), cmbTipo.SelectedItem.ToString(), (int)nudCantidad.Value, Eunidad.Unidades);
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
                    MessageBox.Show("No se cargo ningun medicamento.", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Aviso += ManejadorAviso;

            try
            {
                Laboratorio.Escribir(this.laboratorio, "ArchivoXml.xml");

                Avisar("Se serializaron los datos a XML");
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
                //GuardarCadenaExtension.Guardar(rtbInformacion.Text, "Orden.txt");
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
                MessageBox.Show("Se envió la orden al escritorio", "Informacion",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            Thread hiloLogo = new Thread(CambiarLogo);
            hiloLogo.Start();

            if (rdbConsultar.Checked)
            {
                Consultar();
            }
            else
            {
                if (!(cmbTipo.SelectedItem is null) && !(cmbDroga.SelectedItem is null))
                    Insertar();
                else
                    MessageBox.Show("No se cargo ningun medicamento.", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Muestra todos los medicamentos que hay en la base de datos
        /// </summary>
        public void Consultar()
        {
            try
            {
                List<Medicamento> meds = MedicamentoDAO.GetMedicamentos();

                foreach (Medicamento m in meds)
                {
                    rtbBD.Text += m.ToString() + '\n';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Inserta un medicamento en la base de datos
        /// </summary>
        public void Insertar()
        {
            try
            {
                Medicamento m = new Medicamento(cmbDroga.SelectedItem.ToString(), cmbTipo.SelectedItem.ToString());
                MedicamentoDAO.Insertar(m);

                MessageBox.Show($"Se agregó el medicamento a la BD", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Realiza el cambio de imagen cuando se usa la base de datos
        /// </summary>
        public void CambiarLogo()
        {
            try
            {
                Image logoSql = Image.FromFile("sqlserv.jpg");
                ptbLogo.Image = logoSql;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("No se encontro la imagen.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public event DelegadoAviso Aviso;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="informacion"></param>
        public void Avisar(string informacion)
        {
            if (!Object.ReferenceEquals(this.Aviso, null))
                this.Aviso.Invoke(informacion);
        }
        /// <summary>
        /// Manejador del evento Aviso
        /// </summary>
        /// <param name="cadena">Cadena que se muestra</param>
        public void ManejadorAviso(string cadena)
        {
            MessageBox.Show(cadena, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void timHoraActual_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
