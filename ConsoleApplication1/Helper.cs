using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Helper
    {
        private static Decimal conversionRate = 0.913M;

        public static Decimal ToEuro(Decimal amount)
        {
            return amount *= conversionRate;
        }
    }
}
