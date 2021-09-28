using System;

namespace power
{
    class Harmonic
    {
        static void Main(string[] args)
        {
		
            Console.WriteLine("Enter Upper Power");
            String a = Console.ReadLine();
            float num1 = Convert.ToInt32(a);
	    if (num1 != 0)
	    {
            	float harmonic;
            	float i;
   	    	for(i=1;i<=num1;i++)
            	{
                	harmonic = 1 / i;
                	Console.WriteLine("1/" + i + " :" + harmonic);
            	}
	    }
	    else
	    {
	    	Console.WriteLine("Please Enter Non-Zero Number")
	    }
           
          
        }
    }
}
