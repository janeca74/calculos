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
        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <returns>Retorna a multiplicação de 2 numeros</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
