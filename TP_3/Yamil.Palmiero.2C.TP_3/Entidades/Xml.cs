using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{
    public class Xml<T>
    {
        /// <summary>
        /// Escribe los datos en un archivo tipo Xml.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="datos">Datos a escribir</param>
        /// <returns>True si fue exitoso, false si no</returns>
        public bool Escribir(string ruta, T datos)
        {
            bool retorno = false;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, datos);

                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }
    }
}
