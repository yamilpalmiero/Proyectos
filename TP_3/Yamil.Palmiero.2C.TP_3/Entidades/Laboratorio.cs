using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Laboratorio
    {
        public List<Medicamento> medicamentos;

        /// <summary>
        /// Constructor que inicializa la lista
        /// </summary>
        public Laboratorio()
        {
            this.medicamentos = new List<Medicamento>();
        }

        /// <summary>
        /// Propiedad de Lectura/Escritura para la lista de medicamentos
        /// </summary>
        public List<Medicamento> Medicamentos
        {
            get { return this.medicamentos; }
            set { this.medicamentos = value; }
        }

        /// <summary>
        /// Agrega un medicamento a la lista del laboratorio
        /// </summary>
        /// <param name="laboratorio">Laboratorio</param>
        /// <param name="medicamento">Medicamento</param>
        /// <returns>Laboratorio con el medicamento agregado si se pudo agregar</returns>
        public static Laboratorio operator +(Laboratorio laboratorio, Medicamento medicamento)
        {
            foreach (Medicamento item in laboratorio.medicamentos)
            {
                if (item == medicamento)
                    throw new MedicamentoRepetidoException("Medicamento repetido.");

                laboratorio.medicamentos.Add(medicamento);
            }

            return laboratorio;
        }

        /// <summary>
        /// Escribe los datos del laboratorio en un archivo xml
        /// </summary>
        /// <param name="l">Fabrica a escribir</param>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns>True si fue exitoso, false si no</returns>
        public static bool Escribir(Laboratorio l, string ruta)
        {
            Xml<Laboratorio> escritor = new Xml<Laboratorio>();

            return escritor.Escribir(ruta, l);
        }
    }
}
