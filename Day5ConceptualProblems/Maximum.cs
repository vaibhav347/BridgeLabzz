using System;

namespace max
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number One");
            String a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            Console.WriteLine("Enter Number Two");
            String b = Console.ReadLine();
            int num2 = Convert.ToInt32(b);
            Console.WriteLine("Enter Number Three");
            String c = Console.ReadLine();
            int num3 = Convert.ToInt32(c);
            if (num1 > num2 && num1 > num3)
                Console.WriteLine(num1+" is Maximum");
            else if(num2 > num1 && num2 > num3)
                Console.WriteLine(num2 + " is Maximum");
            else if (num3 > num1 && num3 > num2)
                Console.WriteLine(num3 + " is Maximum");
            else
                Console.WriteLine(num1+","+num2+" and "+num3+" are equal");
        }
    }
}