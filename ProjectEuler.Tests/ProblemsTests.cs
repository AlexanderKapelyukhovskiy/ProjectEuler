using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class ProblemsTests
    {
        [Test]
        public void Problem0001Test()
        {
            Trace.WriteLine(Problem0001.Solution());//233168
        }

        [Test]
        public void Problem0002ListTest()
        {
            for (int i = 1; i < 10; i++)
            {
                long s;
                long f = Problem0002.Fib(i, out s);

                Trace.WriteLine(string.Format("{0} - {1} - {2}", i, f, s));
            }
        }

        [Test]
        public void Problem0002Test()
        {

            int n = 2000000;
            long s;
            long f = Problem0002.Fib(n, out s);

            Trace.WriteLine(string.Format("{0} - {1} - {2}", n, f, s));
            
        }

        [Test]
        public void Problem0003Test()
        {

            var factors = Problem0003.Solution(600851475143);
            var res = new StringBuilder(factors[0].ToString());

            if (factors.Length > 1)
                for (int i = 1; i < factors.Length; i++)
                {
                    res.AppendFormat(", {0}", factors[i]);
                }

            Trace.WriteLine(res);
        }
    }
}