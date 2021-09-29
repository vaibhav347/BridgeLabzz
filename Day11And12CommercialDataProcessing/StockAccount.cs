using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommercialDataProcessing
{
    public class StockAccount: StockDetails
    {
        int share = 1000;
        ArrayList arr = new ArrayList();
        ArrayList arr2 = new ArrayList();
        public void stockAccount()
        {
            Console.WriteLine("**Compony Stocks**");
            Console.WriteLine("\n");
            arr.Add("Compony Name : Infosys");
            arr.Add("Total Stocks : "+share);
            for(int i=0;i<arr.Count;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void transaction()
        {
            int choice;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("**Select Your Choice**");
                Console.WriteLine("\n");
                Console.WriteLine("Buy shares : 1");
                Console.WriteLine("Sell shares : 2");
                Console.WriteLine("Show Portfolio : 3");
                Console.WriteLine("Compony Stock Data : 4");
                Console.WriteLine("Exit : 0");
                Console.WriteLine("\n");
                Console.WriteLine("Enter Your Choice");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch(choice)
                {
                    case 1:
                        buy();
                        break;
                    case 2:
                        sell();
                        break;
                    case 3:
                        save();
                        break;
                    case 4:
                        stockAccount();
                        break;

                }
            } while (choice != 0);
        }
        public void buy()
        {
            Console.WriteLine("\n");
            Console.WriteLine("** You are purchasing shares **");
            Console.WriteLine("\n");
            Console.WriteLine("Enter Customer Name");
            string cname = Console.ReadLine();
            arr2.Add("Customer Name : " + cname);
           //Console.WriteLine("Share Name");
            //string sname = Console.ReadLine();
            //arr2.Add("Compony Name : " + sname);
            Console.WriteLine("Quantity");
            int quantity = int.Parse(Console.ReadLine());
            if (share - quantity >= 0)
            {
                share = share - quantity;
                arr2.Add("Quantity : " + quantity);
                arr.Add("Total Stocks : " + share);
            }
            else
            {
               
                Console.WriteLine("All shares of compony already sold");
                Console.WriteLine("No seller Available");
            }

        }

        public void sell()
        {
            //Console.WriteLine("Enter Customer Name");
            //string cname = Console.ReadLine();
            //arr2.Add("Customer Name : " + cname);
            //Console.WriteLine("Share Name");
            //string sname = Console.ReadLine();
            //arr2.Add("Compony Name : " + sname);
            Console.WriteLine("\n");
            Console.WriteLine("** You are Selling your shares **");
            Console.WriteLine("Quantity to sell");
            int quantity = int.Parse(Console.ReadLine());
            share = share + quantity;
            arr2.Add("Quantity : " + quantity);
            arr.Add("Total Stocks : " + share);
            Console.WriteLine("\n");

        }

        public void save()
        {
            Console.WriteLine("\n");
            Console.WriteLine("** Customer Portfolio **");
            Console.WriteLine("\n");
            for (int i=0;i<arr2.Count;i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
