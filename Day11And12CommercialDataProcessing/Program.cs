using System;

namespace CommercialDataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StockAccount obj1 = new StockAccount();
            obj1.stockAccount();
            obj1.transaction();
        }
    }
}
