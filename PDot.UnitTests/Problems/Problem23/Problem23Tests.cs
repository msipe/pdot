using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class Problem23Tests {
    [Test]
    public void TestUsage() {
      var collator = new SumCollator();
      var factorFinder = new FactorialFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);
      var driver = new PossibleSumsFinder(abundantNumberFinder, collator);
      var runner = new Problem23Runner(driver);
      var result = runner.Execute(24);

      Assert.That(runner.Execute(24), Is.EqualTo(new [] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23}));
      Assert.That(runner.Execute(25), Is.EqualTo(new [] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23}));
      Assert.That(runner.Execute(36), Is.EqualTo(new [] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,26,27,28,29,31,33,34,35}));
      Assert.That(runner.Execute(0), Is.EqualTo(new int[] {}));
      Assert.That(runner.Execute(1), Is.EqualTo(new [] {0}));
    }
  }
}
