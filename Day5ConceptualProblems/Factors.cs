using System;

namespace power
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Find Prime Factors");
            String a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            for(int i=2;i<=num1/2;i++)
            {
                if (num1%i == 0)
                {
                  
                 Console.WriteLine("Prime Factor of num1 is : " + i);

                }
                
            }
           
          
        }
    }
}