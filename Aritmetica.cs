﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public int Somar(int x, int y)
        {
            return x * y; 
        }
        /// <summary>
        /// Operação subtração
        /// </summary>
        /// <returns>Retorna a subtração de 2 numeros</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
