using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLib
{
    public class Triangle : IShape
    {
        public double AB { get; set; }
        public double BC { get; set; }
        public double CA { get; set; }
        private double P;
        public Triangle(double AB, double BC, double CA)
        {
            if (!IsValidTriangle(AB, BC, CA))
            {
                throw new ArgumentException("Треугольник с такими сторонами невозможен.");
            }
            this.AB = AB;
            this.BC = BC;
            this.CA = CA;
            P = GetPerimeter() / 2; 
        }
        public double GetArea()
        {
            return Math.Sqrt(P * (P - AB) * (P - BC) * (P - CA));
        }
        public double GetPerimeter()
        {
            return AB + BC + CA;
        }
        private bool IsValidTriangle(double AB, double BC, double CA)
        {
            return (AB + BC > CA) && (BC + CA > AB) && (CA + AB > BC);
        }
    }
}
