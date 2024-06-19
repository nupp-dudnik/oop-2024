using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17.Triangle
{
    public class RightTriangle(double a, double b) : Triangle(a, b, 90)
    {
        public override double CalculateArea()
        {
            return 0.5 * a * b;
        }
    }
}
