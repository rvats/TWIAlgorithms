using Maths;
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
            int _decimal = 0;
            while (_decimal >= 0)
            {
                Console.Write("Enter Decimal Number : ");
                _decimal = int.Parse(Console.ReadLine());
                Console.WriteLine("The Binary Value for "+ _decimal + " is "+Maths.Maths.CalculateBinary(_decimal));
            }
            
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
