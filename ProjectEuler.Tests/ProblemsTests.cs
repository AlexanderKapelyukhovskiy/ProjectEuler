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
    }
}