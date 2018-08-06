using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  class FactorialFinderTest {
    [Test]
    public void TestFindFactorials() {
      var finder = new FactorialFinder();
      Assert.That(finder.FindFactors(12), Is.EqualTo(new[] {1,2,3,4,6}));
      Assert.That(finder.FindFactors(144), Is.EqualTo(new[] {1,2,3,4,6,8,9,12,16,18,24,36,48,72}));
      Assert.That(finder.FindFactors(5), Is.EqualTo(new[] {1}));
      Assert.That(finder.FindFactors(11), Is.EqualTo(new[] {1}));
      Assert.That(finder.FindFactors(81), Is.EqualTo(new[] {1,3,9,27}));
      Assert.That(finder.FindFactors(0), Is.EqualTo(new int[] {}));
    }
  }
}
