namespace ProjectEuler
{
    public class Problem0004
    {

        public static int Solution(out int maxI, out int maxJ)
        {
            int maxPalindrome = 0;
            maxI = 0;
            maxJ = 0;
            
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int m = i*j;
                    if (IsPalindrome(m) && m > maxPalindrome)
                    {
                        maxPalindrome = m;
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
            return maxPalindrome;
        }

        public static bool IsPalindrome(int num)
        {
            int newNum = 0;
            for (int i = num; i > 0; i = (i / 10))
            {
                int remainder = i % 10;
                newNum = (newNum * 10) + remainder;
            }
            return num == newNum;
        }
    }
}