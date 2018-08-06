using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class FinalValueCounterTest {
    [TestCase(new int[] {},0)]
    [TestCase(new[] { 1},1)]
    [TestCase(new[] { 1, 2 }, 3)]
    [TestCase(new[] { 1,2,3}, 6)]
    public void TestUsage(int[] incomingNums, int expected) {
      var finalValueCounter = new FinalValueCounter();

      Assert.That(finalValueCounter.Tally(incomingNums), Is.EqualTo(expected));
    }
  }
}
