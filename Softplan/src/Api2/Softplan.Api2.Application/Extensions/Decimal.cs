using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.Application.Extensions
{
    public static class Decimal
    {
        public static decimal TruncateDecimal(this double value)
        {
            return (decimal)Math.Truncate(value * 100) / 100;
        }
    }
}