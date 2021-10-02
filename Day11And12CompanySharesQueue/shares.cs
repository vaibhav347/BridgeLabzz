using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day11And12CompanySharesQueue
{
    public class shares
    {
        Queue obj = new Queue();
        string name;
        int choice,share,price;
        public void getData()
        {
            
            do
            {
                Console.WriteLine("Add Compony Data : 1");
                Console.WriteLine("Remove Compony Data : 2");
                Console.WriteLine("View Data : 3");
                Console.WriteLine("Exit : 0");
                Console.WriteLine("---------------");
                Console.WriteLine("Enter Your Choice");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------");

                switch (choice)
                {
                    case 1:
                        buy();
                        break;
                    case 2:
                        sell();
                        break;
                    case 3:
                        showData();
                        break;
                }
            } while (choice != 0);
        }
        void buy()
        {
            DateTime time = DateTime.Now;
            //Console.WriteLine(now);
            Console.WriteLine("Enter Compony Name");
            name = Console.ReadLine();
            obj.Enqueue(name);
            Console.WriteLine("Shares you want to buy");
            share = int.Parse(Console.ReadLine());
            obj.Enqueue(share);
            Console.WriteLine("Each share price");
            price = int.Parse(Console.ReadLine());
            obj.Enqueue(price);
            obj.Enqueue(time);
            Console.WriteLine("---------------");

        }

        void sell()
        {
            //Console.WriteLine("Enter Compony Name");
            //name = Console.ReadLine();
            obj.Dequeue();
            Console.WriteLine("---------------");
        }
        void showData()
        {
            foreach(var data in obj)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("---------------");
        }
    }
}
