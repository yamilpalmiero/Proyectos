using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivos
    {
        public string LeerArchivoTexto(string archivo)
        {
            StreamReader lector = null;

            try
            {
                lector = new StreamReader(archivo, true);
                return lector.ReadToEnd();
            }
            finally
            {
                if (lector != null)
                    lector.Close();
            }
        }



    }
}
