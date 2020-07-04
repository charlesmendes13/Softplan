using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.Application.Extensions
{
    public static class Decimal
    {
        public static decimal TruncateDecimal(this decimal valor, int decimais)
        {
            decimal valorIntegral = Math.Truncate(valor);

            decimal fracao = valor - valorIntegral;

            decimal fator = (decimal)Math.Pow(10, decimais);

            decimal fracaoTruncada = Math.Truncate(fracao * fator) / fator;

            decimal resultado = valorIntegral + fracaoTruncada;

            return resultado;
        }
    }
}