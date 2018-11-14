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
            int position = 0;
            while (position >= 0)
            {
                Console.Write("Enter Fibonnaci Number Position: ");
                position = int.Parse(Console.ReadLine());
                Console.WriteLine("The Fibonacci Value for "+position+" is "+Maths.Maths.Fibonnaci(position));
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
