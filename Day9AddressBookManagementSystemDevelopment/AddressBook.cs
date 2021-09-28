using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace AddressBookManagementSystemDevelopment
{
    class AddressProgram
    {
        static void Main(string[] args)
        {
            WelcomeEmpAddressBook wel = new WelcomeEmpAddressBook();
            Console.WriteLine("Enter value for n");
            int n = int.Parse(Console.ReadLine());
            AddressBook[] book = new AddressBook[n];
            wel.display();
            for (int i = 1; i <= n; i++)
            {
                
                book[i].getInfo();
            }
        }
    }
    public class AddressBook
    {
        public ArrayList[] address = new ArrayList[10];
        public Boolean menu = true;
        public Double keychar;
        int choice;
        string valueString1, valueString2, valueString3, valueString4, valueString5, valueString6, valueString7, valueString8, valueString9;
        public void getInfo()
        {
            do
            {
                Console.WriteLine("Welcome to my address book program");
                Console.WriteLine("*****************************");
                Console.WriteLine("Press 1 to Add an entry to the address book");
                Console.WriteLine("Press 2 to Print the book to the screen");
                Console.WriteLine("Press 3 to Edit a record");
                Console.WriteLine("Press 4 to Search for a record");
                Console.WriteLine("Press 0 to exit ");
                Console.WriteLine("Enter Your Choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Please Enter your Lastname");
                        string str2 = "Lastname";
                        str2 = Console.ReadLine();
                        valueString2 = str2;

                        Console.WriteLine("Please Enter your Firstname");
                        string str1 = "Firstname";
                        str1 = Console.ReadLine();
                        valueString1 = str1;

                        Console.WriteLine("Please Enter your Address, house number and town");
                        string str3 = "Address";
                        str3 = Console.ReadLine();
                        valueString3 = str3;

                        Console.WriteLine("Please Enter your County");
                        string str5 = "County";
                        str5 = Console.ReadLine();
                        valueString5 = str5;

                        Console.WriteLine("Please Enter your Postcode");
                        string str6 = "Postcode";
                        str6 = Console.ReadLine();
                        valueString6 = str6;

                        Console.WriteLine("Please Enter your State");
                        string str7 = "State";
                        str7 = Console.ReadLine();
                        valueString7 = str7;

                        Console.WriteLine("Please Enter your Mail");
                        string str8 = "Mail";
                        str7 = Console.ReadLine();
                        valueString8 = str8;

                        Console.WriteLine("Please Enter your Contatct");
                        string str9 = "Contact";
                        str7 = Console.ReadLine();
                        valueString9 = str9;

                        break;

                    case 2:

                        Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("Lastname you entered: " + valueString2);
                        Console.WriteLine("Firstname you entered: " + valueString1);
                        Console.WriteLine("Address and house number and town you entered: " + valueString3);
                        Console.WriteLine("County you entered: " + valueString5);
                        Console.WriteLine("Postcode you entered: " + valueString6);
                        break;


                }
            } while (choice != 0);
        }
    }

}

