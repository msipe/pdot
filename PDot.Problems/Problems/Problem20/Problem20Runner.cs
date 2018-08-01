using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDot.Problems.Problems.Problem20
{
  public class Problem20Runner
  {
    public int Execute(int incomingNum) {
      var workingPoint = incomingNum;
      var reducedPoint = incomingNum;
      var result = 1;
      
      for (var x = 0; x < incomingNum; x++) {
        reducedPoint = workingPoint - 1;
        result = result * workingPoint;
        workingPoint = reducedPoint;
      }

      return result;
    }
  }
}
