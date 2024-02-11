using mindbox;

var triangle = new Triangle(6, Math.Sqrt(32),35);
var circle = new Circle(5);
 
Console.WriteLine($"Площадь: {triangle.GetArea()}");
Console.WriteLine($"Прямоугольный?: {triangle.IsRight()}");
Console.WriteLine($"Равносторонний?: {triangle.IsEquilateral()}");

Console.WriteLine($"Площадь окружности: {circle.GetArea()}");

