﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23
{
  public class Driver {
    public Driver(AbundantNumberFinder abundantFinder, SumCollator sumCollator) {
      mAbundantFinder = abundantFinder;
      mSumCollator = sumCollator;
    }

    public int[] FindSumsForAbundantNumbers(int max) {
      var abundantNums = new List<int>();
      for (var x = 0; x <= max; x++) {
        if (mAbundantFinder.Check(x)) {
          abundantNums.Add(x);
        }
      }

      return mSumCollator.Collate(abundantNums.ToArray());
    }

    private AbundantNumberFinder mAbundantFinder;
    private SumCollator mSumCollator;
  }
}
