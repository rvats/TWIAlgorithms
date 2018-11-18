using Maths;
using Models;
using System;

namespace MainDemo
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Rectangle2DPlane rectangle1 = new Rectangle2DPlane(2,1,6,4);
            Rectangle2DPlane rectangle2 = new Rectangle2DPlane(3,2,7,5);
            var Area = PuzzleDemo.CalculateOverLapArea(rectangle1,rectangle2);
            Console.WriteLine("Overlapping Area Between Two Given Rectangles is: "+Area);
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
