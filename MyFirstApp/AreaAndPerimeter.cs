using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class AreaAndPerimeter
    {
        public static float CalArea(in float length, in float width)
        {
            return (length * width);
        }
        public static float CalPerimeter(in float length, in float width)
        {
            return 2*(length + width);
        }
    }
}
