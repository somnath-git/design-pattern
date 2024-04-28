

using Prototype;
/*
 * We no need to assign each property again to create same copy
 */


var rectangle = new RectangleShape();
rectangle.Width = 10;
rectangle.Height = 10;

var rectangle2 = rectangle.Clone();

Console.WriteLine("New Rectangle height " + ((RectangleShape)rectangle2).Height);

Console.ReadKey();
