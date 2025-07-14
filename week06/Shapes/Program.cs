using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square newSquare = new Square("Red", 3);
	shapes.Add(newSquare);

        Rectangle newRectangle = new Rectangle("Blue", 3, 7);
	shapes.Add(newRectangle);

        Circle newCircle = new Circle("Yellow", 10);
	shapes.Add(newCircle);

	foreach (Shape shape in shapes)
	{
		string color = shape.GetColor();

		double area = shape.GetArea();

		Console.WriteLine($"The shapes color is {color} and the shapes area is {area}.\n");
	}
    }
}
