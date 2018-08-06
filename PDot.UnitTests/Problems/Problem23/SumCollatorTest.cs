using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class SumCollatorTest {
    [TestCase(new[] { 1}, new int[] {2})]
    [TestCase(new[] { 1, 2 }, new[] { 2,3,4 })]
    [TestCase(new[] { 12, 189, 1767, 1723, 90 }, new[] { 24, 102, 180, 201, 279, 378, 1735, 1779, 1813, 1857, 1912, 1956, 3446, 3490, 3534})]
    [TestCase(new[] { 1, 2, 3 }, new[] {2, 3, 4, 4, 5, 6 })]
    public void TestUsage(int[] incomingNums, int[] expected) {
      var result = mCollator.Collate(incomingNums);
      Assert.That(result, Is.EqualTo(expected));     
    }

    [SetUp]
    public void DoSetup() {
      mCollator = new SumCollator();
    }

    private SumCollator mCollator;
  }
}
