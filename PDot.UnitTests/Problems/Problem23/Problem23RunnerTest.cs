using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class Problem23RunnerTest {
    [Test]
    public void TestUsage() {
      var collator = new SumCollator();
      var valueCounter = new FinalValueCounter();
      var factorFinder = new FactorialFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);
      var possibleSumsFinder = new PossibleSumsFinder(abundantNumberFinder, collator);
      var mysteryNumFinder = new MysteryNumberFinder(possibleSumsFinder);
      var p23Runner = new Problem23Runner(mysteryNumFinder, valueCounter);

      Assert.That(p23Runner.Execute(0), Is.EqualTo("0"));
      Assert.That(p23Runner.Execute(1), Is.EqualTo("0"));
      Assert.That(p23Runner.Execute(2), Is.EqualTo("1"));
      Assert.That(p23Runner.Execute(25), Is.EqualTo("276"));
      Assert.That(p23Runner.Execute(36), Is.EqualTo("544"));
    }
  }
}
