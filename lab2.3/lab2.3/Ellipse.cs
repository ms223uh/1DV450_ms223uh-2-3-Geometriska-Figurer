﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{

    class Ellipse : Shape
    {
        public Ellipse(double length, double width): base(length, width)
        {

        }               

        public override double Area // Uträkning för area.
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }           

        public override double Perimeter  // Uträkning för omkrets.
        {

            get 
            { 
                return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); 
            }

        }          






    }
}
