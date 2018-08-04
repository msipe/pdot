using NUnit.Framework;
using PDot.Problems.Problems.Problem23;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.UnitTests.Problems.Problem23
{
  [TestFixture]
  public class SumCollatorTest {
    [Test]
    public void TestUsage() {
      var collator = new SumCollator();

      

      
    }

    [SetUp]
    public void DoSetup() {
      mAbundantNums = new Mock<IAbundantNumberFinder>();
    }

    private Mock<IAbundantNumberFinder> mAbundantNums;
  }
}
