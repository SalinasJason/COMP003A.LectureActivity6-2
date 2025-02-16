using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Demostrates method overloading for different shape calculations
    /// </summary>
    internal class ShapeCalculator
    {
        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public double CalculateArea(double baseLenght, double height, bool isTriangle)
        {
            return 0.5 * baseLenght * height;
        }
    }
}
