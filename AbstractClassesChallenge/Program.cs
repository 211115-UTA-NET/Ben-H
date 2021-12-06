using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square("AngrySquare", 4, 5);
            Rectangle rectangle1 = new Rectangle("CoolRectangle", 4, 20);
            Triangle triangle1 = new Triangle("UglyTriangle", 3, 7, 3.2, 10);

            square1.SetArea();
            rectangle1.SetArea();
            triangle1.SetArea();

            Console.WriteLine(square1.GetArea());
            Console.WriteLine(rectangle1.GetArea());
            Console.WriteLine(triangle1.GetArea());

        }
    }
}
