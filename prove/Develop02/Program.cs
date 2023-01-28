using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        string response = "";
        Console.WriteLine("Welcome to Journal Master 5000!");
        while(response != "5");

            Console.WriteLine("Please select an option from the following Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");

            response = Console.ReadLine();

            if (response == "1"){
                Journal _JournalEntry = new Journal();

                new promptGenerator.Display();

                new Journal.AddEntry();
            }
            else if(response == "2"){

                new Journal.Display();
            }
            else if(response == "3"){

                Journal.LoadfromFile();
            }
            else if(response == "4"){

                Journal.SavefromFile();
            }
            else if(response == "5"){

                Console.WriteLine("Thank you for using Journal Master 5000!");
            }
            else{
                Console.WriteLine("Please enter a valid input");
            }
    }
}