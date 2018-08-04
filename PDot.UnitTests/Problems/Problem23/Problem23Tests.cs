using NUnit.Framework;
using PDot.Problems.Problems.Problem23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class Problem23Tests {
    [Test]
    public void TestUsage() {
      var collator = new SumCollator();
      var factorFinder = new FactorialFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);

      var runner = new Problem23Runner(collator, abundantNumberFinder);

      var result = runner.Execute(100);

      Assert.That(result, Is.EqualTo(new [] { 10 }));

    }
  }
}
