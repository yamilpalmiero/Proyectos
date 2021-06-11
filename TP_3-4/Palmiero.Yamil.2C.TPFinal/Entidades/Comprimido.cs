using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Comprimido : Medicamento
    {
        public enum ETipoVenta
        {
            VentaLibre,
            Recetado
        }

        private int cantidadPorBlister;
        private ETipoVenta tipoVenta;

        public Comprimido(string nombre, string codigo,int stock, DateTime fechaVencimiento, int cantidad, ETipoVenta tipo)
            : base(nombre, codigo, stock)
        {
            this.cantidadPorBlister = cantidad;
            this.tipoVenta = tipo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de vencimiento: {this.FechaVencimiento.AddMonths(12).ToShortDateString()}");
            sb.AppendLine($"Cantidad por blister: {this.cantidadPorBlister.ToString()}");
            sb.AppendLine($"Distribucion: {this.tipoVenta.ToString()}");

            return sb.ToString();
        }
    }
}
