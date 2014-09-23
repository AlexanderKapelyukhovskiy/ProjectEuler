using System;

namespace ProjectEuler
{
    public class Problem0007
    {

        public static long Solution(int n)
        {
            int k = 0, i = 0;
            while (k < n)
            {
                i++;
                if (IsPrime(i))
                    k++;
                
            }
            return i;
        }

        public static bool IsPrime(long n)
        {
            if (n <= 3)
                return n > 1;
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i < Math.Sqrt(n) + 1; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}