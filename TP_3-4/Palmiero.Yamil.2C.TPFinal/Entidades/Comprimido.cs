using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Comprimido : Medicamento, IDatos<Comprimido>
    {
        /// <summary>
        /// Enumerado para las posibles formas de venta del medicamento
        /// </summary>
        public enum ETipoVenta
        {
            VentaLibre,
            Recetado
        }

        private int cantidadPorBlister;
        private ETipoVenta tipoVenta;


        /// <summary>
        /// Constructor por defecto del Comprimido
        /// </summary>
        public Comprimido()
        {

        }

        /// <summary>
        /// Crea un nuevo medicamento en pastillas
        /// </summary>
        /// <param name="nombre">Nombre del medicamento</param>
        /// <param name="codigo">Cpdigo del medicamento</param>
        /// <param name="stock">Cantidad en stock de ese medicamento</param>
        /// <param name="cantidad">Cantidad de comprimidos que entran por blister</param>
        /// <param name="tipo">Manera en la cual se vende al publico</param>
        public Comprimido(string nombre, int stock, int cantidad, ETipoVenta tipo)
            : base(nombre, stock)
        {
            this.cantidadPorBlister = cantidad;
            this.tipoVenta = tipo;
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad por blister
        /// </summary>
        public int CantidadBlister
        {
            get
            {
                return this.cantidadPorBlister;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadPorBlister = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de solo elctura del tipo de venta
        /// </summary>
        public string TipoVenta
        {
            get
            {
                return this.tipoVenta.ToString();
            }
        }


        /// <summary>
        /// Muestra la información del medicamento
        /// </summary>
        /// <param name="item">Medicamento a mostrar</param>
        /// <returns>String con la informacion del medicamento</returns>
        public string MostrarDatosMedicamento(IDatos<Comprimido> item)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de vencimiento: {DateTime.Now.AddMonths(20).ToShortDateString()}");
            sb.AppendLine($"Cantidad: {this.CantidadBlister.ToString()}");
            sb.AppendLine($"Blisters (2 unidades): {(this.CantidadBlister/2).ToString()}");
            sb.AppendLine($"Distribucion: {this.TipoVenta}");

            return sb.ToString();
        }

        /// <summary>
        /// Polimorfismo del ToString.
        /// </summary>
        /// <returns>String con la informacion del medicamento</returns>
        public override string ToString()
        {
            return MostrarDatosMedicamento(this);
        }
    }
}
