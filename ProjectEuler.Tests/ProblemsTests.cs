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

        [Test]
        [TestCase(112, false)]
        [TestCase(11211, true)]
        [TestCase(2222, true)]
        public void Problem0004IsPalindromeTest(int num, bool result)
        {
            Assert.That(Problem0004.IsPalindrome(num), Is.EqualTo(result));
        }

        [Test]
        public void Problem0004Test()
        {
            int i,j;
            var result = Problem0004.Solution(out i, out j);
            Trace.WriteLine(string.Format("{0} = {1}*{2} ", result, i, j));
        }

        [Test]
        public void Problem0005Test()
        {
            var result = Problem0005.Solution(20);
            Trace.WriteLine(result);
        }

        [Test]
        public void Problem0006Test()
        {
            var result = Problem0006.Solution();
            Trace.WriteLine(result);

            result = Problem0006.Solution2();
            Trace.WriteLine(result);
        }

        [Test]
        public void Problem0007Test()
        {
            var result = Problem0007.Solution(10001);
            Trace.WriteLine(result);
        }

        [Test]
        public void Problem0008Test()
        {
            //var r = Problem0008.Multiply("12345");
            //Trace.WriteLine(r);
            var result = Problem0008.Solution();
            Trace.WriteLine(result);
        }
    }
}