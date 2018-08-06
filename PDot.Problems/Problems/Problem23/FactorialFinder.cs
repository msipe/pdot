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
      for (var x = 1; x <= Math.Sqrt(incoming); x++) {
        if ((incoming % x) == 0 ) {
          results.Add(x);
          var multiplier = (incoming / x);

          if (multiplier != x && multiplier != incoming) {
            results.Add(multiplier);
          }
        }
      }

      return results.OrderBy(x => x).ToArray();
    }
  }
}
