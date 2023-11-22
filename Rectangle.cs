using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLib
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }
        public double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
