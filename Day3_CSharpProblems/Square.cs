using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharpProblems
{
     class Square: Shape
    {
        public Square(double side)
        {
            Dim = side;
        }
        public override double CalcArea()
        {
            return Dim * Dim;
        }
    }
}
