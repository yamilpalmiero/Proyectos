using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    //Se incluyen en Xml las clases que hereda Periferico
    [XmlInclude(typeof(Comprimido))]
    [XmlInclude(typeof(Inyectable))]

    public class Medicamento
    {
        public string nombre;
        public ETipo tipo;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Medicamento()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre">Nombre del medicamento</param>
        /// <param name="tipo">Tipo de distribucion del medicamento</param>
        public Medicamento(string nombre, ETipo tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        /// <summary>
        /// Propiedad de Lectura/Escritura del nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Propiedad de Lectura/Escritura del tipo de distribucion
        /// </summary>
        public ETipo Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        /// <summary>
        /// Muestra la informacion basica del medicamento
        /// </summary>
        /// <returns>Informacion</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.Append($"Dsitribucion: {this.tipo.ToString()}");

            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Informacion();
        }

        /// <summary>
        /// Compara dos medicamentos por su nombre
        /// </summary>
        /// <param name="m1">Nombre primer medicamento</param>
        /// <param name="m2">Nombre segundo medicamento</param>
        /// <returns>True si son el mismo</returns>
        public static bool operator ==(Medicamento m1, Medicamento m2)
        {
            return m1.nombre == m2.nombre;
        }
        /// <summary>
        /// Compara dos medicamentos por su nombre
        /// </summary>
        /// <param name="m1">Nombre primer medicamento</param>
        /// <param name="m2">Nombre segundo medicamento</param>
        /// <returns>True si son el mismo</returns>
        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
            return !(m1 == m2);
        }
    }
}
