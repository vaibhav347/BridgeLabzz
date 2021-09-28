using System;

namespace division
{
    class QuotientReminder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Divisor Number");
            String num1 = Console.ReadLine();
            float divisor = Convert.ToInt32(num1);
            Console.WriteLine("Enter Divider Number");
            String num2 = Console.ReadLine();
            float divider = Convert.ToInt32(num2);

            float quotient = divisor / divider;
            float reminder = divisor % divider;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Reminder is : " + reminder);
        }
    }
}