using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInheritance
{
    public class Point : Shape
    {
        public override string Name => nameof(Point);
        public float X;
        public float Y;

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override float GetSize()
        {
            return 0;
        }
    }
}
