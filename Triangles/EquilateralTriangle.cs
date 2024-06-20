using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17.Triangles
{
    public class EquilateralTriangle(double a) : Triangle(a, a, 60)
    {
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * a * a;
        }
    }
}
