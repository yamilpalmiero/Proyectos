using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Entidades
{
    public static class MedicamentoDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        /// <summary>
        /// Inicializa las variables para utilizarse en los metodos
        /// </summary>
        static MedicamentoDAO()
        {
            conexion = new SqlConnection(@"Data Source=.; Database = Laboratorio; Trusted_Connection = true;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        /// <summary>
        /// Inserta un medicamento en la base de datos.
        /// </summary>
        /// <param name="m">Medicamento a guardar</param>
        /// <returns>Devuelve true si salio todo bien, lanza una excepcion si algo falló</returns>
        public static void Insertar(Medicamento m)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Medicamentos VALUES(@Nombre)";
                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("Nombre", m.Nombre));

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Error de SQL", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
