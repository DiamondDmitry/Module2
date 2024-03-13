using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IShape
    {
        public double CalculateArea(int radius, int sideA, int sideB);
    }

    public class Circle : IShape
    {
        public double CalculateArea(int radius, int sideA = 0, int sideB = 0)
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : IShape
    {
        public double CalculateArea(int sideA, int sideB, int radius = 0)
        {
            return sideA * sideB;
        }
    }

}
