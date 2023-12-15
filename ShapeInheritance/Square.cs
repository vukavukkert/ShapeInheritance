using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInheritance
{
    public class Square : Shape
    {
        public Point P1, P2, P3, P4;
        public Line L1, L2, L3, L4;
        public Square(Point p1, Point p2, Point p3, Point p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            L1 = new Line(P1, P2);
            L2 = new Line(P2, P3);
            L3 = new Line(P3, P4);
            L4 = new Line(P4, P1);
        }
        public override float GetSize()
        {
            var p = (L1.GetSize() + L2.GetSize() + L3.GetSize() + L4.GetSize())/2;
            return (float) Math.Sqrt((p - L1.GetSize()) * (p - L2.GetSize()) * (p - L3.GetSize()) * (p - L4.GetSize()));
        }
    }
}
