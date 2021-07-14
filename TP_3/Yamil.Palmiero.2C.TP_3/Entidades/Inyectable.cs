using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inyectable : Medicamento
    {
        public int cantidad;
        public Eunidad unidad;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Inyectable()
        {

        }
        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="nombre">Nombre del medicamento</param>
        /// <param name="tipo">Tipo de distribucion</param>
        /// <param name="cantidad">Cantidad</param>
        /// <param name="unidad">Unidad de medida</param>
        public Inyectable(string nombre, ETipo tipo, int cantidad, Eunidad unidad)
            : base(nombre, tipo)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
        }

        /// <summary>
        /// Propiedad de Lectura/Escritura de la cantidad
        /// </summary>
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        /// <summary>
        /// Propiedad de Lectura/Escritura de la unidad
        /// </summary>
        public Eunidad Unidad
        {
            get { return this.unidad; }
            set { this.unidad = value; }
        }

        /// <summary>
        /// Muestra la informacion completa
        /// </summary>
        /// <returns>Informacion</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cantidad: {this.cantidad} {this.unidad}");

            return sb.ToString();
        }
    }
}
