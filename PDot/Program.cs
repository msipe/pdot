using PDot.Problems.Problems.Problem20;
using PDot.Problems.Problems.Problem23;
using System;
using System.Numerics;

namespace PDot{
  class Program {
    static void Main(string[] args) {
      var problem = args[0];
      var input = args[1];
      SolveProblem(problem, input);
    }

    private static void SolveProblem(string problem, string input) {
      switch (problem) {
        case "20":
          Console.WriteLine(new Problem20Runner().Execute(BigInteger.Parse(input)));
          break;
        case "23":
          ExecuteProblem23(int.Parse(input));
          break;
        default:
          Console.WriteLine("unrecognized problem");
          break;
      }
    }

    private static void ExecuteProblem23(int max) {
      var collator = new SumCollator();
      var factorFinder = new FactorFinder();
      var abundantNumberFinder = new AbundantNumberFinder(factorFinder);
      var valueCounter = new FinalValueCounter();
      var possibleSumFinder = new PossibleSumsFinder(abundantNumberFinder, collator);
      var mysteryNumberFinder = new MysteryNumberFinder(possibleSumFinder);
      var problem23Runner = new Problem23Runner(mysteryNumberFinder, valueCounter);

      Console.WriteLine(problem23Runner.Execute(max));

    }
  }
}
