using System;

namespace perfect
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Check Is it Perfect or not");
            String a = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int sum = 0;
            
            for(int i=1;i<=num/2;i++)
            {
                if (num%i == 0)
                {
                    sum = sum + i;
                }
                
            }
            if (sum == num)
                Console.WriteLine(num + " Number is perfect number");
            else
                Console.WriteLine(num + " is not perfect number");
           
          
        }
    }
}
