using System.Linq;

namespace PDot.Problems.Problems.Problem23 {
  public class AbundantNumberFinder  {
    public AbundantNumberFinder (FactorialFinder finder) {
      mFinder = finder;
    }
    public bool Check(int incoming) {
      return mFinder.FindFactors(incoming).Sum() > incoming;
    }

    private FactorialFinder mFinder;
  }
}
