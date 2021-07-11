using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicamento
    {
        private string nombre;
        private int stock;


        /// <summary>
        /// Constructor por defecto de Medicamento
        /// </summary>
        public Medicamento()
        {

        }

        /// <summary>
        /// Crea un nuevo medicamento
        /// </summary>
        /// <param name="nombre">Nombre del medicamento</param>
        /// <param name="codigo">Codigo del medicamento</param>
        /// <param name="stock">Cantidad en stock que hay de ese medicamento</param>
        protected Medicamento(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        /// <summary>
        /// Propiedad de solo lectura para el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        

        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad de stock
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Valida que el codigo del medicamento sea correcto
        /// </summary>
        /// <param name="cadena">Codigo a validar</param>
        /// <returns>Retorna true si esta bien, false si no</returns>
        public bool Validar(string cadena)
        {
            bool retorno = false;

            if (cadena.Length == 6)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Polimorfismo del ToString para mostrar los datos comunes a todo tipo de medicamento
        /// </summary>
        /// <returns>Datos del medicamento</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.Nombre}");

            return sb.ToString();
        }


        /// <summary>
        /// Compara una lista de medicamentos con un medicamento para ver si esta
        /// </summary>
        /// <param name="medicamentos">Lista de medicamentos</param>
        /// <param name="m">Medicamento</param>
        /// <returns>Retorna true si existe el medicamento en la lista</returns>
        public static bool operator ==(List<Medicamento> medicamentos, Medicamento m)
        {
            bool retorno = false;

            foreach (Medicamento item in medicamentos)
            {
                if (m.Nombre.Equals(item.Nombre))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Compara una lista de medicamentos con un medicamento para ver si no esta
        /// </summary>
        /// <param name="medicamentos">Lista de medicamentos</param>
        /// <param name="m">Medicamento</param>
        /// <returns>Retorna true si no esta</returns>
        public static bool operator !=(List<Medicamento> medicamentos, Medicamento m)
        {
            return !(medicamentos == m);
        }


        /// <summary>
        /// Agrega un medicamento a la lista
        /// </summary>
        /// <param name="medicamentos">Lista de medicamentos</param>
        /// <param name="m">Medicamento que se quiere agregar</param>
        /// <returns>La lista de medicamentos actualizada</returns>
        public static List<Medicamento> operator +(List<Medicamento> medicamentos, Medicamento m)
        {
            if (medicamentos != m)
            {
                medicamentos.Add(m);
            }

            return medicamentos;
        }
    }
}
