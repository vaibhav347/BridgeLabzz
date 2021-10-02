using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12CompanySharesLinkedList
{
    public class shares
    {
        LinkedList<string> obj = new LinkedList<string>();
        string share, price,name;
        int choice;
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
            obj.AddFirst(name);
            Console.WriteLine("Shares you want to buy");
            share = Console.ReadLine();
            obj.AddFirst(share);
            Console.WriteLine("Each share price");
            price = Console.ReadLine();
            obj.AddFirst(price);
            Console.WriteLine("---------------");

        }

        void sell()
        {
            Console.WriteLine("Enter Compony Name");
            name = Console.ReadLine();
            obj.Remove(name);
            Console.WriteLine("---------------");
        }
        void showData()
        {
            foreach(string data in obj)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("---------------");
        }
    }
}
