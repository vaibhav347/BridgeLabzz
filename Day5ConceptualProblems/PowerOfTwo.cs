using System;

namespace power
{
    class PowerOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Upper Power");
            String a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
	    if (num1 >= 1 && num1 <= 31)
	    {
            	int power = 1;
            	Console.WriteLine("2 power 0 :1");

            	for (int i=1;i<=num1;i++)
            	{
                	power = power * 2;
               		Console.WriteLine("2 power " + i + " :" + power);
            	}
	    }
	    else
		Console.WriteLine("Please Enter Number Between 1 to 31");
           
          
        }
    }
}
