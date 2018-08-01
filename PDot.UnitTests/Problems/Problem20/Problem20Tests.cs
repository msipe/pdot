using NUnit.Framework;
using PDot.Problems.Problems.Problem20;

namespace PDot.UnitTests.Problems.Problem20
{
  [TestFixture]
  class Problem20Tests  {
    [Test]
    public void TestUsage() {
      var runner = new Problem20Runner();
      Assert.That(runner.Execute(10), Is.EqualTo(3628800));
      Assert.That(runner.Execute(5), Is.EqualTo(120));
      Assert.That(runner.Execute(1), Is.EqualTo(1));
    }
  }
}
