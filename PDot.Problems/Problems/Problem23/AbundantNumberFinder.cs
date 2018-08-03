using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class AbundantNumberFinder  {
    public AbundantNumberFinder (FactorialFinder finder) {
      mFinder = finder;
    }
    public bool Check(int incoming) {
      var factors = mFinder.FindFactors(incoming);
      var result = 0;
      for (var x = 0; x < factors.Length; x++) {
        result = result + factors[x];
      }

      if (result <= incoming) {
        return false;
      }
      return true;
    }

    private FactorialFinder mFinder;
  }
}
