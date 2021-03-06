using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz generica para producir el medicamento
    /// </summary>
    /// <typeparam name="T">Medicamento a producir</typeparam>
    public interface IProduccion<T>
        where T : class
    {
        bool Producir(IProduccion<T> elemento);
    }
}
