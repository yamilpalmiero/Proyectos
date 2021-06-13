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
        /// Carga los medicamentos que se necesitan producir
        /// </summary>
        /// <param name="medicamento">Medicamento a producir</param>
        /// <param name="cantidad">Cantidad necesaria</param>
        public void Cargar(string nombre, string codigo, int stock, float temperatura, Inyectable.EAplicacion aplicacion)
        {
            this.inyectables.Add(new Inyectable(nombre, codigo, stock, temperatura, aplicacion));
        }
        public void Cargar(string nombre, string codigo, int stock, int cantidad, Comprimido.ETipoVenta venta)
        {
            this.comprimidos.Add(new Comprimido(nombre, codigo, stock, cantidad, venta));
        }

        /// <summary>
        /// Informa si el inyectable ya esta en la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="inyectable">Medicamento inyectable</param>
        /// <returns>True si ya esta</returns>
        public static bool operator ==(Orden orden, Inyectable inyectable)
        {
            bool retorno = false;

            foreach (Inyectable item in orden.inyectables)
            {
                if (item.Nombre.Equals(inyectable.Nombre))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Informa si el inyectable no esta en la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="inyectable">Medicamento inyectable</param>
        /// <returns>True si no esta</returns>
        public static bool operator !=(Orden orden, Inyectable inyectable)
        {
            return !(orden == inyectable);
        }

        /// <summary>
        /// Informa si el inyectable ya esta en la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="comprimido">Medicamento tipo comprimido</param>
        /// <returns>True si ya esta</returns>
        public static bool operator ==(Orden orden, Comprimido comprimido)
        {
            bool retorno = false;

            foreach (Comprimido item in orden.comprimidos)
            {
                if (item.Nombre.Equals(comprimido.Nombre))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Informa si el comprimido no esta en la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="comprimido">Medicamento tipo comprimido</param>
        /// <returns>True si no esta</returns>
        public static bool operator !=(Orden orden, Comprimido comprimido)
        {
            return !(orden == comprimido);
        }

        /// <summary>
        /// Agrega un inyectable a la lista de inyectables de la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="inyectable">Medicamento inyectable</param>
        /// <returns>Orden de produccion actualizada si pudo agregar el inyectable</returns>
        public static Orden operator +(Orden orden, Inyectable inyectable)
        {
            if (orden != inyectable)
            {
                orden.inyectables.Add(inyectable);
            }

            return orden;
        }

        /// <summary>
        /// Agrega un medicamento comprimido a la lista de comprimidos de la orden de produccion
        /// </summary>
        /// <param name="orden">Orden de produccion</param>
        /// <param name="comprimido">Medicamento de tipo comprimido</param>
        /// <returns>Orden de produccion actualizada si pudo agregar el comprimido</returns>
        public static Orden operator +(Orden orden, Comprimido comprimido)
        {
            if (orden != comprimido)
            {
                orden.comprimidos.Add(comprimido);
            }

            return orden;
        }



    }
}
