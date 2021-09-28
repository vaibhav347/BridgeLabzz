using System;

namespace Day8LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y2");
            int y2 = int.Parse(Console.ReadLine());

            Welcome obj = new Welcome();
            UC1 obj2 = new UC1();
            obj.disply();
            obj2.getAxis(x1,x2,y1,y2);
        }
    }
}
