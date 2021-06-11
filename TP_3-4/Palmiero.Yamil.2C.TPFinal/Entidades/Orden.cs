using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Orden
    {
        private static List<Medicamento> listaMedicamentos;

        static Orden()
        {
            Orden.listaMedicamentos = new List<Medicamento>();
        }

        public static Medicamento Medicamento
        {
            set
            {
                if (listaMedicamentos != value)
                {
                    listaMedicamentos += value;
                }
            }
        }

        public static string Producir()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Medicamento m in listaMedicamentos)
            {
                if (m is Comprimido)
                {
                    sb.AppendLine("----------------------------------------------------------");
                    sb.AppendLine("COMPRIMIDOS");
                    sb.AppendLine(m.ToString());
                }
                else
                {
                    sb.AppendLine("----------------------------------------------------------");
                    sb.AppendLine("VACUNAS");
                    sb.AppendLine(m.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
