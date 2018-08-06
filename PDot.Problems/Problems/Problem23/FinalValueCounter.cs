using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class FinalValueCounter {
    public int Tally(int[] incoming) {
      var result = 0;
      for (var x =0; x < incoming.Length; x++) {
        result += incoming[x];
      }
      return result;
    }
  }
}
