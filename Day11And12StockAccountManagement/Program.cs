using System;

namespace Day11And12ObjectOrientedPrograms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stocks obj = new Stocks();
             
        Console.WriteLine("In how many componies you want to invest");
            int compony = int.Parse(Console.ReadLine());
            for(int i=1;i<=compony;i++)
            {
                obj.getData();
            }
            obj.portfolio();

        }
    }
}
