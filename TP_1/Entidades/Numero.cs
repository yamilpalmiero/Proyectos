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
        private double numero;
        #endregion

        #region Sobrecarga de Constructores
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            this.SetNumero(numero);
        }
        #endregion

        #region Propiedades
        public void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }
        #endregion

        #region Metodos
        private double ValidarNumero(string strNumero)
        {
            double numero;

            if (double.TryParse(strNumero, out numero))
                return numero;
            return 0;
        }
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
                return false;

            return true;
        }
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double resultado = 0;

                for (int i = 0; i < binario.Length; i++)
                    resultado += int.Parse(binario[i].ToString()) * (Math.Pow(2, binario.Length - 1 - i));

                return resultado.ToString();
            }
            else
                return "Valor inválido";
        }
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
        public string DecimalBinario(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
                return "Valor inválido";

            return DecimalBinario(auxNumero);
        }
        #endregion

        #region Sobrecarga de Operadores
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;

            return n1.numero / n2.numero;
        }
        #endregion
    }
}
