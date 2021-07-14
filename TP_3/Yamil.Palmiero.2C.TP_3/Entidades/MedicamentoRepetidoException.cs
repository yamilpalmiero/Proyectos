using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepción que se lanzará en caso que un medicamento se encuentre repetido.
    /// </summary>
    [Serializable]
    public class MedicamentoRepetidoException : Exception
    {
        public MedicamentoRepetidoException(string mensaje)
            : base(mensaje)
        {

        }
        public MedicamentoRepetidoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
