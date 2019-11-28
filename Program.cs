using System;

namespace MethodsTraining {
  class Program {
    static void Main (string[] args) {
      var calculator = new Calculator ();
      var result1 = calculator.Add (new int[] { 1, 2, 3, 4, });
      var result2 = calculator.Add ({ 1, 2, 3, 4, });
      var point = new Point (10, 20);
      point.Move (new Point (34, 21));

      point.Move (100, 200);
      Console.WriteLine ("Point is: {0},{1}", point.X, point.Y);
    };
  }
}