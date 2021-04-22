using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos

        /// <summary>
        /// Realiza el calculo seleccionado entre los dos numeros
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Indica la operacion a realizar</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Valida que el operador sea '+' '-' '*' o '/'
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Retorna el operador si es valido, si no lo es retorna el operador '+'</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador.Equals("+") || operador.Equals("-") || operador.Equals("*") || operador.Equals("/"))
                return operador;

            return "+";
        }
        #endregion
    }
}
