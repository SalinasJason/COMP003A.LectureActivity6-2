using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Represents a rectangle with a specific area calculation.
    /// </summary>
    internal class Rectangle : Shape
    {
        // Auto-implemented propperties for the length and width of the rectangle.
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Constructor for the Rectangle class
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name="width"></param>
        public Rectangle(double lenght, double width)
        {
            Length = lenght; 
            Width = width;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area: {Length * Width}");
        }
    }
}
