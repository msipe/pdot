using System.Numerics;

namespace PDot.Problems.Problems.Problem20
{
  public class Problem20Runner
  {
    public BigInteger Execute(BigInteger incomingNum) {
      return GetSumOfAllDigits(GetProduct(incomingNum));
    }

    private BigInteger GetProduct(BigInteger incomingNum) {
      var workingPoint = incomingNum;
      var reducedPoint = incomingNum;
      BigInteger result = 1;
      
      for (var x = 0; x < incomingNum; x++) {
        reducedPoint = workingPoint - 1;
        result = result * workingPoint;
        workingPoint = reducedPoint;
      }

      return result;
    }

    private BigInteger GetSumOfAllDigits(BigInteger incomingNum) {
      var convertedNum = incomingNum.ToString();
      BigInteger result = 0;
      for (var x = 0; x < convertedNum.Length; x++) {
        result = result + BigInteger.Parse(convertedNum[x].ToString());
      }

      return result;
    }
  }
}
