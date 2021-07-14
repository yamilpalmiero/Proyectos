﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardarCadenaExtension
    {
        /// <summary>
        /// Guarda la cadena en un archivo de texto en el escritorio con el nombre indicado, agregando nueva información al final del archivo
        /// </summary>
        /// <param name="texto">Cadena a guardar en el escritorio</param>
        /// <param name="archivo">Nombre del archivo donde se guardará</param>
        /// <returns>Devuelve true si salió bien, o lanza una excepción si salió mal</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter sw = null;
            try
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo))
                {
                    sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo, true);
                    sw.WriteLine(texto);
                }
                else
                {
                    sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo);
                    sw.WriteLine(texto);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error de archivo", e);
            }
            finally
            {
                if (!(sw is null))
                {
                    sw.Close();
                }
            }
            return true;
        }
    }
}
