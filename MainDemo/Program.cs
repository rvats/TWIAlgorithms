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
            Demo.TreeTraversal();
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
