using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharpProblems
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Dim = radius;
        }
        public override double CalcArea()
        {
            return Dim * Dim * Math.PI;
        }
    }
}
