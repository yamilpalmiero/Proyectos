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
            conexion = new SqlConnection(@"Data Source=.; Initial Catalog = Medicamentos; Integrated Security = true;");
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
                comando.CommandText = "INSERT INTO Medicamentos(Nombre, Tipo) VALUES(@Nombre, @Tipo)";
                comando.Parameters.AddWithValue("@Nombre", m.Nombre);
                comando.Parameters.AddWithValue("@Tipo", m.Tipo);

                if (conexion.State != System.Data.ConnectionState.Open)
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


        /// <summary>
        /// Devuelve todos los medicamentos de la BD
        /// </summary>
        /// <returns>Medicamentos</returns>
        public static List<Medicamento> GetMedicamentos()
        {
            comando.CommandText = "SELECT Codigo, Nombre, Tipo FROM Medicamentos";
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                List<Medicamento> lista = new List<Medicamento>();

                while (oDr.Read())
                {
                    int codigo;
                    int.TryParse(oDr["Codigo"].ToString(), out codigo);
                    string nombre = oDr["Nombre"].ToString();
                    string tipo = oDr["Tipo"].ToString();

                    Medicamento med = new Medicamento(nombre, tipo);
                    lista.Add(med);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                    conexion.Close();
            }
        }
    }
}
