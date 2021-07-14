using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class CantidadInvalidaException : Exception
    {
        public CantidadInvalidaException(string mensaje)
           : base(mensaje)
        {

        }
        public CantidadInvalidaException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
