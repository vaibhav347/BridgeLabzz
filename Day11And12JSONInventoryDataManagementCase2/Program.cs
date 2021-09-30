using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Day11And12JSONInventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            Rice ricedata = fetchJsonForRice.Read("C:/Users/3011313/Desktop/BridgeLabzz/Day11And12JSONInventoryDataManagementCase2/Rice.json");

            for (int i = 0; i < ricedata.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfPulses[i].name);
                Console.WriteLine(ricedata.TypesOfPulses[i].Price);
                Console.WriteLine(ricedata.TypesOfPulses[i].weight);
                int cost = ricedata.TypesOfPulses[i].Price * ricedata.TypesOfPulses[i].weight;
                Console.WriteLine("Total Cost : " +cost);
                Console.WriteLine("------");
            }

           /* for (int i = 0; i < ricedata.TypesOfRice.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfRice[i].name);
                Console.WriteLine(ricedata.TypesOfRice[i].Price);
                Console.WriteLine(ricedata.TypesOfRice[i].weight);
                Console.WriteLine("------");
            }*/

        }
    }
}