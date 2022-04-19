using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeries
{
    public static class Series
    {
        public static long fibonacci(long to)
        {
            return fibonacci(0, to);
        }

        public static long fibonacci(long from, long to)
        {
            if (to < 2)
            {
                return 1;
            }
  
            long fibNumber = 0;

    
            fibNumber += fibonacci(from, to - 1) + fibonacci(from, to - 2);
            

            return fibNumber;
        }

        public static double pi(long to)
        {
            return pi(0, to);
        }

        public static double pi(long from, long to)
        {
            double pi = 0;

            for (long i = from; i < to; i++)
            {
                pi += (((i % 2) == 0) ? +1.0 : -1.0) / (2.0 * i + 1.0);
            }

            pi = 4 * pi;
            return pi;
        }

        public static double eulersNumber(long to)
        {
            return eulersNumber(0, to);
        }

        public static double eulersNumber(long from, long to)
        {
            double eulerianNumber = 0;

            for (long i = from; i <= to; i++)
            {
                eulerianNumber += 1.0 / Math.faculty(i);
            }

            return eulerianNumber;
        }
    }
}
