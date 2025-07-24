using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Area
    {
        public float CalArea(float side)
        {
            return (side*side);
        }
        public float CalArea(float length,float width)
        {
            return (length * width);
        }
        public float CalArea(float radius, bool isCircle)
        {
            return (MathF.PI*radius*radius);
        }
    }
}
