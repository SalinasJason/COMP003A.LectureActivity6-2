using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Represents a circle with a specific area calculation
    /// </summary>
    internal class Circle : Shape
    {
        // Auto-implemented property for the radius of the circle.
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for the Circle class.
        /// </summary>
        /// <param name="radius"></param>
        public Circle (double radius)
        {
            Radius = radius;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius} ");
        }
    }
}
