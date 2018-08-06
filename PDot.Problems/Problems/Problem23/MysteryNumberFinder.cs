using System.Collections.Generic;
using System.Linq;

namespace PDot.Problems.Problems.Problem23
{
  public class MysteryNumberFinder {
    public MysteryNumberFinder(PossibleSumsFinder driver) {
      mDriver = driver;
    }
    public int[] Execute(int max) {
      return FindMysteryNumbers(max);
    }

    private int[] FindMysteryNumbers(int max) {
      var possibleSums = mDriver.FindSumsForAbundantNumbers(max);
      var result = new List<int>();
      for (var x = 0; x < max; x++) {
        if (!possibleSums.Contains(x)) {
          result.Add(x);
        }
      }

      return result.ToArray();
    }



    private PossibleSumsFinder mDriver;
  }
}
