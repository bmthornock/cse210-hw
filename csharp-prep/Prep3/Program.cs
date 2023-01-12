using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string input = "yes";

            while (input == "yes")
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 101);

                int guess = -1;

                while (guess != number)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess > number)
                    {   
                        Console.Write("Your guess is higher than the number. ");
                        Console.Write(" ");
                    }

                    else if (guess < number)
                    {
                        Console.Write("Your guess is lower than the number. ");
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("Congrats! You guessed the number.");
                    }
                }

            Console.Write("Would you like to play again? (yes/no)");
            input = Console.ReadLine();
            }
        Console.Write("Thanks for playing!");
    }


}