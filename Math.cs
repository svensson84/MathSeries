using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeries
{
    public static class Math
    {
        public static long faculty(long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;

            return n * faculty(n - 1);
        }
    }
}
