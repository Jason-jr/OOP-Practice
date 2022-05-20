// See https://aka.ms/new-console-template for more information

using OOP;

var shapes = new Shape[]
{
    new Circle(2, 0),
    new Square(3, 4),
    new Triangle(5, 6)
};

foreach (var s in shapes)
    Execute(s, s.GetType().Name);

static void Execute(Shape shape, string name)
{
    Console.WriteLine("Area of {0}:", name);
    shape.CalcArea();
    shape.PrintArea();
}