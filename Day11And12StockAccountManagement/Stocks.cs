using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day11And12ObjectOrientedPrograms
{
   public class Stocks:Investments
    {
        ArrayList ar = new ArrayList();
        string name;
        int share, price, totalCost;
        public override void getData()
        {
            Console.WriteLine("Enter Compony Name");
            name = Console.ReadLine();
            ar.Add("Compony Name :"+name);
            Console.WriteLine("\n"); 

            Console.WriteLine("How many shares you want to buy");
            share =int.Parse( Console.ReadLine());
            ar.Add("Total Share : "+share);
            Console.WriteLine("\n");

            Console.WriteLine("Price of each share");
            price = int.Parse(Console.ReadLine());
            ar.Add("Per Share Price : "+price);
            Console.WriteLine("\n");

            totalCost = share * price;
            ar.Add("Total Investment : "+totalCost);


        }

        public void portfolio()
        {
            Console.WriteLine("Your Portfolio");
            Console.WriteLine("\n");
            for(int i=0;i<ar.Count;i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
