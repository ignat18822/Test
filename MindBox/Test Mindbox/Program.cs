using Figure.CalculationArea;

var radius = 8.88 ;

var height = 5.55;
var weight= 7 ;

var side = 5.2;

var a = 4;
var b = 6.43;
var c=7.56;

var sidesPolygon = new List<double> { 4.5, 6.543, 7,8.546,9 };

var circle = new CircleArea(radius);
var square = new SquareArea(side);
var rectangle = new RectangleArea(height, weight);
var triangle = new TriangleArea(a, b, c);
var polygon = new PolygonArea(sidesPolygon);

Console.WriteLine($"Area circle  {circle.Calculation()}");
Console.WriteLine($"Area square  {square.Calculation()}");
Console.WriteLine($"Area rectangle  {rectangle.Calculation()}");
Console.WriteLine($"Area triangle  {triangle.Calculation()}");
Console.WriteLine($"Area polygon  {polygon.Calculation()}");




