using System;

namespace MethodsTraining {
  class Program {
    static void Main (string[] args) {
      var calculator = new Calculator ();
      var result1 = calculator.Add (new int[] { 1, 2, 3, 4, });
      var result2 = calculator.Add ({ 1, 2, 3, 4, });
    };
  }
}