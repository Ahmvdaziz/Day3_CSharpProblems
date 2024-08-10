using System;

namespace Day3_CSharpProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = GetShapesFromUser();
            Picture pic = new Picture(shapes);
            pic.DisplayAllShapesArea();
        }

        static Shape[] GetShapesFromUser()
        {
            Console.WriteLine("Enter the number of shapes:");
            int numShapes = int.Parse(Console.ReadLine());
            Shape[] shapes = new Shape[numShapes];

            for (int i = 0; i < numShapes; i++)
            {
                Console.WriteLine("Select shape (1: Rectangle, 2: Square, 3: Circle):");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the length of the rectangle:");
                        double length = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width of the rectangle:");
                        double width = double.Parse(Console.ReadLine());
                        shapes[i] = new Rectangle(length, width);
                        break;
                    case 2:
                        Console.WriteLine("Enter the side of the square:");
                        double side = double.Parse(Console.ReadLine());
                        shapes[i] = new Square(side);
                        break;
                    case 3:
                        Console.WriteLine("Enter the radius of the circle:");
                        double radius = double.Parse(Console.ReadLine());
                        shapes[i] = new Circle(radius);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        i--;
                        break;
                }
            }

            return shapes;
        }
    }
}
