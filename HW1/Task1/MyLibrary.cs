using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyLibrary
    {
        public static double squareQuadrat (double width, double height)
        {
            return width * height;
        }
        public static double squareRectangle(double width, double height)
        {
            return width * height;
        }

        public static double squareTriangle(double baseLine, double height)
        {
            return 0.5 * baseLine * height;
        }


    }
}
