namespace ProjectEuler
{
    public class Problem0002
    {
        public long Solution()
        {
            return 0;
        }

        public static long Fib(int n, out long s, long limit = 4000000)
        {
            s = 0;
            if (n == 1)
                return 1;
            s = 2;
            if (n == 2)
                return 2;

            long sum = 2;
            long prev1 = 1;
            long prev2 = 2;
            long l = 3;
            for (int i = 3; i <= n; i++)
            {
                long t = prev1 + prev2;
                if (t > limit)
                    break;

                l = t;
                if (l % 2 == 0)
                    sum += l;

                prev1 = prev2;
                prev2 = l;
            }
            s = sum;
            return l;
        }
    }
}