using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AvisarExtension
    {
        /// <summary>
        /// Avisa que el medicamento ya esta agregado
        /// </summary>
        /// <param name="ex">Objeto exception</param>
        /// <returns>Mensaje de aviso</returns>
        public static string AvisarMedicamentoRepetido(this MedicamentoRepetidoException ex)
        {
            return "El Medicamento ya esta en la lista.";
        }
    }
}
