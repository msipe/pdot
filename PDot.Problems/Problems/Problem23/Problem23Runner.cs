using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem23
{
  public class Problem23Runner {
    public void Execute() {
      var factorer = new FactorialFinder();
      var finder = new AbundantNumberFinder(factorer);
      var result = new List<int>();
      for (var x = 0; x < 28123; x++) {
        if (finder.Check(x)) {
          result.Add(x);
        }
      }

      Array.ForEach(result.ToArray(), r => { Console.WriteLine(r); });
    }
  }
}
