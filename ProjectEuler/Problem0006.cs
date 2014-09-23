using System;

namespace ProjectEuler
{
    public class Problem0006
    {
        public static long Solution(int n = 100)
        {
            long s1 = 0;
            long s2 = 0;
            for (int i = 1; i <= n; i++)
            {
                s1 += i*i;
                s2 += i;
            }
            return s2*s2 - s1;
        }

        public static long Solution2(int n = 100)
        {
            //(1 + 2 + ... + n)^2 = n^2 * (n+1)^2 * 1/4
            //1^2 + 2^2 + ... + n^2 = n * (n+1) * (2n+1) * 1/6

            long s2 = n*n*(n + 1)*(n + 1)/4;
            long s1 = n*(n+1)*(2*n+1)/6;
            return s2 - s1;
        }

        
    }
}