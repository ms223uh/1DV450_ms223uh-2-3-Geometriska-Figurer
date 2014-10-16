using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    public class Rectangle : Shape
    {

        public Rectangle(double length, double width) : base(length, width)
        {

        }


        public override double Area  // Uträkning för area.
        {
            get { return Length * Width; }
        }

        
        public override double Perimeter  // Uträkning för omkrets.
        {
            get { return (2 * Length) + (2 * Width); }
        }

        
    }
}
