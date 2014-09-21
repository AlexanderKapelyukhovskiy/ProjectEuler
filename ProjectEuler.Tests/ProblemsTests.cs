using System.Diagnostics;
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
    }
}