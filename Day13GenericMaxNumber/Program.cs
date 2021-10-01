using System;

namespace Day13GenericMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arri = { 10, 20, 30 };
            double[] arrd = { 10.0, 20.0, 30.0 };
            char[] arrc = { 'a', 'b' };
            max obj = new max ();
            
            
            obj.maxNum(arri);
            obj.maxNum(arrd);
            obj.maxNum(arrc);
        }
    }
}
