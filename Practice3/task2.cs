using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public static class task2
    {
        public static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        public static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) ||
                   IsPerfectSquare(5 * n * n - 4);
        }
    }
}
