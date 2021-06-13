using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CodigoRepetidoException : Exception
    {
        /// <summary>
        /// Mensaje de codigo repetido
        /// </summary>
        public CodigoRepetidoException()
            :base("Codigo repetido.")
        {

        }
    }
}
