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
  class DriverTest {
    [Test]
    public void TestFindSumsForAbundantNumbers() {
      var col = new SumCollator();
      var ff = new FactorialFinder();
      var af = new AbundantNumberFinder(ff);
      
      var driver = new Driver(af, col);
      Assert.That(driver.FindSumsForAbundantNumbers(12), Is.EqualTo(new int[] {}));
      Assert.That(driver.FindSumsForAbundantNumbers(24), Is.EqualTo(new[] {30,32,36,38,42,44}));
      Assert.That(driver.FindSumsForAbundantNumbers(0), Is.EqualTo(new int[] { }));
      Assert.That(driver.FindSumsForAbundantNumbers(2), Is.EqualTo(new int[] { }));
    }
  }
}
