using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public static class task1
    {
        public static BigInteger CalculateProduct(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Початок повинен бути менше або дорівнювати кінцю");
            }

            BigInteger product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
