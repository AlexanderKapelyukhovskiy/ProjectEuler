using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Problem0003
    {
        public static long[] Solution(long num)
        {
            long b;

            long a = num;//600851475143;
            var factors = new List<long>();

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                        factors.Add(b);
                    }
                    //sb.AppendFormat(" ,{0}", b); // Console.WriteLine("{0} is a prime factor {1} times!", b, x));
                }
            return factors.ToArray();
        }
    }
}