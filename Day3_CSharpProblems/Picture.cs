using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharpProblems
{
     class Picture
    {

        public Shape[] Shapes;
        public Picture(Shape[] shapes)
        {
            Shapes = shapes;
        }
        public void DisplayAllShapesArea()
        {
            double sum = 0;
            foreach (Shape shape in Shapes)
            {
                sum += shape.CalcArea();
            }
            Console.WriteLine($"Total area of all shapes: {sum}");

        }
    }
}
