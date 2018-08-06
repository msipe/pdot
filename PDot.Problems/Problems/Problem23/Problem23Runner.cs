using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class Problem23Runner {
    public Problem23Runner(PossibleSumsFinder possibleSumsFinder, FinalValueCounter valueCounter) {
      mPossibleSumsFinder = possibleSumsFinder;
      mValueCounter = valueCounter;
    }
    public string Execute() {
      return "hey";
    }

    private PossibleSumsFinder mPossibleSumsFinder;
    private FinalValueCounter mValueCounter;
  }
}
