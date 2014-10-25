using System;

namespace ProjectEuler
{
    public class Problem0012
    {
        public static long Solution(int n = 500)
        {
            checked
            {
                int i = 1;
                int dividersCount;
                long triangle = 0;

                do
                {
                    triangle += i++;
                    dividersCount = Factor(triangle);

                } while (dividersCount < n);

                return triangle;
            }
        }

        public static int Factor(long number)
        {
            int count = 0;
            var max = (long)Math.Sqrt(number);  //round down
            for (long factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    count++;
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        count++;
                    }
                }
            }
            return count;
        }

    }
}