using NUnit.Framework;
using PDot.Problems.Problems.Problem23;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class SumCollatorTest {
    [TestCase(new[] { 1}, new int[] {})]
    [TestCase(new[] { 1, 2 }, new[] { 3 })]
    [TestCase(new[] { 12, 189, 1767, 1723, 90 }, new[] { 102, 201, 279, 1735, 1779, 1813, 1857, 1912, 1956, 3490})]
    [TestCase(new[] { 1, 2, 3 }, new[] { 3, 4, 5 })]
    public void TestUsage(int[] incomingNums, int[] expected) {
      var collator = new SumCollator();
      var result = collator.Collate(incomingNums);
      Assert.That(result, Is.EqualTo(expected));     
    }
  }
}
