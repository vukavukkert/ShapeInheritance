using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeInheritance
{
    public class Line : Shape
    {
        public override string Name => nameof(Line);
        public float Length;
        public Point X, Y;
        public Line(Point x, Point y)
        {
            X = x; Y = y;
        }
        public override float GetSize()
        {
            return (float) Math.Sqrt(Math.Pow((X.X - Y.X), 2) + Math.Pow((X.Y - Y.Y), 2));
            //d = √(x2 - x1)^2 + (y2 - y1)^2
        }
    }
}
