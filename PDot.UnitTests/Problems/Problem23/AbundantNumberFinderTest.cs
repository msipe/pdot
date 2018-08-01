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
  class AbundantNumberFinderTest {
    [Test]
    public void TestExecute() {
      var factorFinder = new FactorialFinder();
      var finder = new AbundantNumberFinder(factorFinder);
      Assert.That(finder.Check(12), Is.True);
      Assert.That(finder.Check(11), Is.False);
      Assert.That(finder.Check(13), Is.False);
    }
  }
}
