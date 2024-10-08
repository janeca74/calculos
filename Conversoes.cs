﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão em temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }
        /// <summary>
        /// Tipo de conversão de distancias
        /// </summary>
        public enum ConversaoDistancia
        {
           Nulo = 0,
           MetrosMilhas,
           MilhasMetros
        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
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
        /// <summary>
        /// Conversão de distancias
        /// </summary>
        /// <param name="conversao"></param>
        /// <param name="distancia"></param>
        /// <returns></returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return (distancia * 0.0006215712);
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return (distancia = 1609.340);
            }
            return -1;
        }
    }
}
