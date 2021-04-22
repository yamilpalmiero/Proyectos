using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        /// <summary>
        /// Numero de la entidad
        /// </summary>
        private double numero;
        #endregion

        #region Sobrecarga de Constructores

        /// <summary>
        /// Constructor por defecto con numero en cero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que asigna el numero pasado por parametro
        /// </summary>
        /// <param name="numero">Numero a asignar</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que asigna un numero previamente validado
        /// </summary>
        /// <param name="numero">Numero a asignar</param>
        public Numero(string numero)
        {
            this.SetNumero(numero);
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Asigna el numero tras una validacion
        /// </summary>
        /// <param name="numero">Numero a guardar en forma de string</param>
        public void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Valida que el string recibido sea un numero
        /// </summary>
        /// <param name="strNumero">Numero que recibe en forma de string</param>
        /// <returns>Numero validado, si no es valido devuelve cero</returns>
        private double ValidarNumero(string strNumero)
        {
            double numero;

            if (double.TryParse(strNumero, out numero))
                return numero;

            return 0;
        }
        /// <summary>
        /// Valida que el numero sea binario
        /// </summary>
        /// <param name="binario">Numero a validar</param>
        /// <returns>True si el numero es binario y False si no</returns>
        private bool EsBinario(string binario)
        {
            bool esBinario = true;

            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                }
            }
            return esBinario;
        }
        /// <summary>
        /// Convierte un binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario a convertir</param>
        /// <returns>Numero decimal o "Valor invalido" si no se pudo convertir</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado;

            if (EsBinario(binario))
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);
                double numero = 0;

                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += Math.Pow(2, i);
                        }
                    }
                }
                resultado = numero.ToString();
            }
            else
            {
                resultado = "Valor inválido";
            }

            return resultado;
        }
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>Numero binario o "Valor invalido" si no se pudo convertir</returns>
        public string DecimalBinario(double numero)
        {
            int auxNumero = (int)numero;

            if (auxNumero > 0 && auxNumero < 256)
            {
                string resultado = "";

                do
                {
                    resultado = (auxNumero % 2) + resultado;
                    auxNumero = (int)auxNumero / 2;
                } while (auxNumero > 0);

                return resultado;
            }
            else
                return "Valor inválido";
        }
        /// <summary>
        /// Convierte un numero decimal en forma de string a binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>Numero binario o "Valor invalido" si no se pudo convertir</returns>
        public string DecimalBinario(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
                return "Valor inválido";

            return DecimalBinario(auxNumero);
        }
        #endregion

        #region Sobrecarga de Operadores

        /// <summary>
        /// Suma los atributos de tipo numero de dos Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Resta los atributos de tipo numero de dos Numero    
        /// </summary>
        /// <param name="n1">Primer nuemero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Multiplica los atributos de tipo numero de dos Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Producto entre ambos numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Divide los atributos de tipo numero de dos Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Cociente entre ambos numeros</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;

            return n1.numero / n2.numero;
        }
        #endregion
    }
}
