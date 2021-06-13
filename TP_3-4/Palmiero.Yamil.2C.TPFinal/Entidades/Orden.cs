using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Orden
    {
        private static List<Medicamento> medicamentos;

        /// <summary>
        /// Crea una nueva orden inicializando la lista
        /// </summary>
        static Orden()
        {
            Orden.medicamentos = new List<Medicamento>();
        }

        /// <summary>
        /// Propiedad que agrega un medicamento en la lista, si este no existe
        /// </summary>
        public static Medicamento Medicamento
        {
            set
            {
                if (medicamentos != value)
                {
                    medicamentos += value;
                }
            }
        }

        /// <summary>
        /// Muestra la informacion completa del medicamento
        /// </summary>
        /// <returns>Detalles del medicamento</returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Medicamento m in medicamentos)
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
            return sb.ToString();
        }
    }
}
