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
      var driver = new Driver();
      Assert.That(driver.FindSumsForAbundantNumbers(10), Is.EqualTo(new[] {1,2,3}));
    }
  }
}
