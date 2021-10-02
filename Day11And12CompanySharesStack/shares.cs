using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day11And12CompanySharesStack
{
    public class shares
    {
        Stack obj = new Stack ();
        string name;
        int choice, share, price;
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
            Console.WriteLine("Enter Compony Name");
            name = Console.ReadLine();
            obj.Push(name);
            Console.WriteLine("Shares you want to buy");
            share = int.Parse(Console.ReadLine());
            obj.Push(share);
            Console.WriteLine("Each share price");
            price = int.Parse(Console.ReadLine());
            obj.Push(price);
            Console.WriteLine("---------------");

        }

        void sell()
        {
            //Console.WriteLine("Enter Compony Name");
            //name = Console.ReadLine();
            obj.Pop();
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
