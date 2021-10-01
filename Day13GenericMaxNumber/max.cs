using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day13GenericMaxNumber
{
    public class max
    {

        public void maxNum<T>(T[] arr)
        {
            T maximum = arr.Max();
            Console.WriteLine("Maximum Number : " + maximum);
            Console.WriteLine("------------------");

        }
    }
}
