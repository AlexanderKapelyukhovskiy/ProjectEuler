using System.Collections;

namespace ProjectEuler
{
    public class Problem0010
    {
        public static long Solution()
        {
            const int limit = 1999999;
            var bits = SieveOfEratosthenes(limit);
            long s = 0;
            for (int i = 0; i < limit; i++)
            {
                if (bits[i])
                    s += i;
            }
            return s;
        }

        public static BitArray SieveOfEratosthenes(int limit)
        {
            long s = 0;
            var bits = new BitArray(limit + 1, true);
            bits[0] = false;
            bits[1] = false;
            for (int i = 0; i * i <= limit; i++)
            {
                if (bits[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        bits[j] = false;
                    }
                }
            }
            return bits;
        }
    }
}