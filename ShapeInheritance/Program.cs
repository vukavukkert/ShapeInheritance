// See https://aka.ms/new-console-template for more information

using ShapeInheritance;

var p1 = new Point(0, 0);
var p2 = new Point(5, 0); //5
var p3 = new Point(5, 4); //4
var p4 = new Point(2, 4);
Console.WriteLine(new Line(p1, p2).GetSize());
Console.WriteLine(new Line(p2, p3).GetSize());
Console.WriteLine(new Line(p3, p4).GetSize());
Console.WriteLine(new Line(p4, p1).GetSize());
Square sqr = new Square(p1, p2, p3, p4);
Console.WriteLine(sqr.GetSize());
