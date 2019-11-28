using System;

namespace MethodsTraining {
  class Point {
    public int X;
    public int Y;

    public Point (int x, int y) {
      this.X = x;
      this.Y = y;
    };

    public void Move (int x, int y) {
      this.X = x;
      this.Y = y;
    };

    public void Move (Point newLocation) {
      this.X = newLocation.x;
      this.Y = newLocation.y;
    };
  }
}