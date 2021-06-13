using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Inyectable : Medicamento, IDatos<Inyectable>
    {
        /// <summary>
        /// Enumerado para los posibles tipos de aplicacion
        /// </summary>
        public enum EAplicacion
        {
            Endovenosa,
            Intramuscular
        }

        private float temperaturaConservacion;
        private EAplicacion aplicacion;

        /// <summary>
        /// Crea un nuevo medicamento inyectable
        /// </summary>
        /// <param name="nombre">Nombre del medicamento</param>
        /// <param name="codigo">Codigo del medicamento</param>
        /// <param name="stock">Cantidad en stock de ese medicamento</param>
        /// <param name="temperatura">Temperatura a la cual conservar el farmaco</param>
        /// <param name="aplicacion">Tipo de aplicacion</param>
        public Inyectable(string nombre, string codigo, int stock, float temperatura, EAplicacion aplicacion)
            : base(nombre, codigo, stock)
        {
            this.temperaturaConservacion = temperatura;
            this.aplicacion = aplicacion;
        }


        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad por blister
        /// </summary>
        public float Temperatura
        {
            get
            {
                return this.temperaturaConservacion;
            }
            set
            {
                this.temperaturaConservacion = value;
            }
        }

        /// <summary>
        /// Propiedad de solo elctura del tipo de venta
        /// </summary>
        public string Aplicacion
        {
            get
            {
                return this.aplicacion.ToString();
            }
        }

        /// <summary>
        /// Muestra la información del medicamento
        /// </summary>
        /// <param name="item">Medicamento a mostrar</param>
        /// <returns>String con la informacion del medicamento</returns>
        public string MostrarDatosMedicamento(IDatos<Inyectable> item)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de vencimiento: {DateTime.Now.AddMonths(12).ToShortDateString()}");
            sb.AppendLine($"Temperatura de conservacion: {this.Temperatura.ToString()}");
            sb.AppendLine($"Aplicacion: {this.Aplicacion}");

            return sb.ToString();
        }

        /// <summary>
        /// Polimorfismo del ToString
        /// </summary>
        /// <returns>String con la informacion del medicamento</returns>
        public override string ToString()
        {
            return MostrarDatosMedicamento(this);
        }
    }
}
