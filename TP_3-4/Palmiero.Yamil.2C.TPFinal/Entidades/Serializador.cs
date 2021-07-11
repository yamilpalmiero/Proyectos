using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T>
         where T : new()
    {
        public void Serializar(T obj, string ruta)
        {
            XmlTextWriter escritor = null;
            XmlSerializer serializador = null;

            try
            {
                escritor = new XmlTextWriter(ruta, Encoding.UTF8);
                serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(escritor, obj);
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }
        }
    }
}
