using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Inyectable : Medicamento
    {
        public enum EAplicacion
        {
            Endovenosa,
            Intramuscular
        }

        private float temperaturaConservacion;
        private EAplicacion aplicacion;

        public Inyectable(string nombre, string codigo, int stock, float temperatura, EAplicacion aplicacion)
            :base(nombre, codigo, stock)
        {
            this.temperaturaConservacion = temperatura;
            this.aplicacion = aplicacion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de vencimiento: {this.FechaVencimiento.AddMonths(24).ToShortDateString()}");
            sb.AppendLine($"Cantidad por blister: {this.temperaturaConservacion.ToString()}");
            sb.AppendLine($"Distribucion: {this.aplicacion.ToString()}");

            return sb.ToString();
        }
    }
}
