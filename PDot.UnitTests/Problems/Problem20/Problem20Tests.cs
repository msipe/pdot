using NUnit.Framework;
using PDot.Problems.Problems.Problem20;
using System.Numerics;

namespace PDot.UnitTests.Problems.Problem20
{
  [TestFixture]
  class Problem20Tests  {
    [Test]
    public void TestUsage() {
      var runner = new Problem20Runner();
      Assert.That(runner.Execute(100), Is.EqualTo(new BigInteger(648)));
      Assert.That(runner.Execute(10), Is.EqualTo(new BigInteger(27)));
      Assert.That(runner.Execute(5), Is.EqualTo(new BigInteger(3)));
      Assert.That(runner.Execute(1), Is.EqualTo(new BigInteger(1)));
    }
  }
}
