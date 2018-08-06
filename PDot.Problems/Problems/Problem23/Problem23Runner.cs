using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class Problem23Runner {
    public Problem23Runner(MysteryNumberFinder mysterNumberFinder, FinalValueCounter valueCounter) {
      mMysteryNumberFinder = mysterNumberFinder;
      mValueCounter = valueCounter;
    }
    public string Execute(int max) {
      return mValueCounter
               .Tally(mMysteryNumberFinder.Execute(max))
               .ToString();
    }

    private MysteryNumberFinder mMysteryNumberFinder;
    private FinalValueCounter mValueCounter;
  }
}
