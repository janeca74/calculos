using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão em temperatura a executar
        /// </summary>
        public static enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public static int Somar(int x, int y)
        {
            return x * y; 
        }
        /// <summary>
        /// Operação subtração
        /// </summary>
        /// <returns>Retorna a subtração de 2 numeros</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.0000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                    return ((temperatura - 32) / 1.0000);
            }
            return -1;
        }
    }
}
