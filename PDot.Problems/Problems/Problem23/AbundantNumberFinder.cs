using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class AbundantNumberFinder:IAbundantNumberFinder  {
    public AbundantNumberFinder (FactorialFinder finder) {
      mFinder = finder;
    }
    public bool Check(int incoming) {
      return mFinder.FindFactors(incoming).Sum() > incoming;
    }

    private FactorialFinder mFinder;
  }
}
