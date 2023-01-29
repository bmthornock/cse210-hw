using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal myJournal = new Journal();

        PromptGenerator myPromptGenerator = new PromptGenerator();

        string response = "0";
        Console.WriteLine("Welcome to Journal Master 6000!");
        while(response != "5")
        {
            Console.WriteLine("Please select an option from the following Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");

            response = Console.ReadLine();

            if (response == "1"){

                myPromptGenerator.Display();

                myJournal.AddEntry();
            }
            else if(response == "2"){

                myJournal.Display();
            }
            else if(response == "3"){

                myJournal.LoadfromFile();
            }
            else if(response == "4"){

                myJournal.SaveToFile();
            }
            else if(response == "5"){

                Console.WriteLine("Thank you for using Journal Master 5000!");
            }
            else{
                Console.WriteLine("Please enter a valid input");
            }
        }
    }
}