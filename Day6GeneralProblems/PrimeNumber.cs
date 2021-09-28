using System;

namespace prime
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Check Is it Prime or not");
            String a = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int flag = 0;
            
            for(int i=2;i<=num/2;i++)
            {
                if (num%i == 0)
                {
                    flag = 1; 
                }
                
            }
            if (flag == 1)
                Console.WriteLine(num + " Number is not prime");
            else
                Console.WriteLine(num + " is prime");
           
          
        }
    }
}
