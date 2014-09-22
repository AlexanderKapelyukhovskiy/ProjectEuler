namespace ProjectEuler
{
    public class Problem0005
    {
        public static long Solution(int n)
        {
            for (int i = n; i < long.MaxValue; i++)
            {
                if (DevidedByAll(i, n))
                    return i;
            }
            return 0;
        }

        public static bool DevidedByAll(long v, int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (v%i != 0)
                    return false;
            }
            return true;
        }
    }
}