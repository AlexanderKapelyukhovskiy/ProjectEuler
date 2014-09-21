namespace ProjectEuler
{
    public class Problem0001
    {
        public static long Solution()
        {
            return GetSumOfThreeAndFiveMultipliers(1000);
        }

        public static long GetSumOfThreeAndFiveMultipliers(long max)
        {
            long result = 0;
            for (long i = 3; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}