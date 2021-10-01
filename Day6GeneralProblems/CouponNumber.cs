using System;

namespace CouponNumber
{
    class Program
    {
        static void coupon()
        {
            Console.WriteLine("Enter How Many Coupon Numbers You Want To Generate");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            for(int i=0;i<n;i++)
            {
                Random rand = new Random();
                int num = rand.Next(1,20);
                int flag = 0;
              
                for(int j=0;j<=i;j++)
                {
                    if(arr[j] == num)
                    {
                        flag = 1;
                        count++;
                        break;
                    }
                }
                if (flag == 0)
                {
                    arr[i] = num;
                    count++;
                }
            }

            Console.WriteLine("** Coupon Numbers **");
            Console.WriteLine("\n");
            for (int i=0; i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Total Rounds : "+count);
        }
        static void Main(string[] args)
        {
            CouponNumber.coupon();
        }
    }
}
