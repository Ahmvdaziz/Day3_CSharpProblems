using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharpProblems
{
    class Rectangle : Shape
    {
        private double _width;
        public Rectangle(double length, double width)
        {
            Dim = length;
            _width = width;
        }
        public override double CalcArea()
        {
            return Dim * _width;
        }

    }
}
