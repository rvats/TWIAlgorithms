using System;

namespace MainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Depth First Traversal Demo");
            Demo.DepthFirstTraversal();
            Console.WriteLine("========================================================================");
            Console.ReadKey();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Breadth First Traversal Demo");
            Demo.BreadthFirstTraversal();
            Console.WriteLine("========================================================================");
            Console.ReadKey();
        }
    }
}
