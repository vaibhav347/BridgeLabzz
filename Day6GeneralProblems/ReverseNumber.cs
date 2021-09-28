using System;

namespace reverse
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            String a = Console.ReadLine();
            int num = Convert.ToInt32(a);
            Console.WriteLine("Entered number is : " + num);
            int reminder = 0,rev = 0;
            while(num != 0)
            {
                reminder = num % 10;
                rev = rev * 10 + reminder;
                num = num / 10;
            }
            
               Console.WriteLine("Reverse number : "+rev);
            
          
        }
    }
}