using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    public class GeometricFigure
    {
        public GeometricFigure()
        {

        }
        public GeometricFigure(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; } = 1;
        public int Width { get; set; } = 1;

        public void dosomething()
        {
            Console.WriteLine("Actually does something");
        }
    }
}
