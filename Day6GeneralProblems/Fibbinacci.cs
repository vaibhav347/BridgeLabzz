using System;

namespace fibbo
{
    class Fibbinacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Find Fibbonacci series");
            String a = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num1 = 0, num2 = 1, num3 = 0;
            Console.Write(num1 + " " + num2 + " ");
            for(int i=2;i<num;i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
                
            }
           
          
        }
    }
}