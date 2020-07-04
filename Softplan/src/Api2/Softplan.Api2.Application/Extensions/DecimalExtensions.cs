using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.Application.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal TruncateDecimal(this decimal value, int places)
        {
            decimal step = (decimal)Math.Pow(10, places);
            decimal tmp = Math.Truncate(step * value);

            return tmp / step;
        }
    }
}