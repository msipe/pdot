using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23
{
  public class Problem23Runner {
    public Problem23Runner(SumCollator sumCollator, AbundantNumberFinder abundantFinder) {
      mSumCollator = sumCollator;
      mAbundantFinder = abundantFinder;
    }
    public int[] Execute(int max) {
      return new[] { 10 };
    }



    private SumCollator mSumCollator;
    private AbundantNumberFinder mAbundantFinder;
  }
}
