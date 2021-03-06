﻿using System.Linq;

namespace PDot.Problems.Problems.Problem23 {
  public class AbundantNumberFinder  {
    public AbundantNumberFinder (FactorFinder finder) {
      mFinder = finder;
    }

    public bool Check(int incoming) {
      return mFinder.FindFactors(incoming).Sum() > incoming;
    }

    private FactorFinder mFinder;
  }
}
