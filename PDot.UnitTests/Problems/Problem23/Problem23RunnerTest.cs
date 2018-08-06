using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class Problem23RunnerTest {
    public void TestUsage() {
      var collator = new SumCollator();
      var valueCounter = new FinalValueCounter();
      var factorFinder = new FactorialFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);
      var possibleSumsFinder = new PossibleSumsFinder(abundantNumberFinder, collator);
      var p23Runner = new Problem23Runner(possibleSumsFinder, valueCounter);

    }
  }
}
