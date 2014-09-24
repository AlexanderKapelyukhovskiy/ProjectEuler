namespace ProjectEuler
{
    public class Problem0009
    {
        public static int Solution()
        {
            for (int i = 998; i > 0; i--)
            {
                for (int j = 1; j < 999 - i; j++)
                {
                    int c = 1000 - i - j;
                    if (i*i == j*j + c*c)
                        return i*j*c;
                }
            }
            return 0;
        }
    }
}