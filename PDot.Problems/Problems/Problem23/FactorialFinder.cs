using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23
{
  public class FactorialFinder  {
    public int[] FindFactors(int incoming) {
      var results = new List<int>();
      for (var x = 1; x < incoming; x++) {
        if ((incoming % x) == 0 ) {
          results.Add(x);
        }
      }

      return results.ToArray();
    }
  }
}
