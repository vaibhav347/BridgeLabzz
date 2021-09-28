using System;

namespace number
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            String num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            if (num2 % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
        }
    }
}
