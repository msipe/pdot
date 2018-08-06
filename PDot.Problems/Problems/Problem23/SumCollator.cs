using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23 {
  public class SumCollator {
    public int[] Collate(int[] abundantNumbers) {
      var sums = new List<int>();

      for (var x = 0; x < abundantNumbers.Length; x++) {
        for (var y = x; y < abundantNumbers.Length; y++) {
          var sum = abundantNumbers[x] + abundantNumbers[y];
          if (sum < 28124) {
            sums.Add(sum);
          }
        }
      }
      return sums.OrderBy((s) => (s)).ToArray();
    }
  }
}
