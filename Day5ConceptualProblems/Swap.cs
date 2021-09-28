using System;

namespace num
{
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number One");
            String a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            Console.WriteLine("Enter Number Two");
            String b = Console.ReadLine();
            int num2 = Convert.ToInt32(b);

            Console.WriteLine("Befor Swapping");
            Console.WriteLine("Num1 : " + num1);
            Console.WriteLine("Num2 : " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

           
           Console.WriteLine("\n");
           Console.WriteLine("After Swapping");
           Console.WriteLine("Num1 : "+num1);
           Console.WriteLine("Num2 : "+num2);
        }
    }
}
