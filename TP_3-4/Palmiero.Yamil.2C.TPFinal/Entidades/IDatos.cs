using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz generica que muestra los datos de un medicamento dependiendo su tipo
    /// </summary>
    /// <typeparam name="T">Tipo de dato</typeparam>
    public interface IDatos<T> where T : class
    {
        string MostrarDatosMedicamento(IDatos<T> clase);
    }
}
