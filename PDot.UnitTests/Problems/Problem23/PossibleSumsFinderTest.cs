using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  class PossibleSumsFinderTest {
    [Test]
    public void TestFindPossibleSums() {
      var factorFinder = new FactorialFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);
      var collator = new SumCollator();
      var possibleSumsFinder = new PossibleSumsFinder(abundantNumberFinder, collator);

      Assert.That(possibleSumsFinder.FindSumsForAbundantNumbers(0), Is.EqualTo(new int[] {}));
      Assert.That(possibleSumsFinder.FindSumsForAbundantNumbers(1), Is.EqualTo(new int[] {}));
      Assert.That(possibleSumsFinder.FindSumsForAbundantNumbers(25), Is.EqualTo(new[] {24,30,32,36,36,38,40,42,44,48}));
    }
  }
}
