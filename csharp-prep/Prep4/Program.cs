using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        
        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum of your numbers is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {average}");

        
        int biggest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > biggest)
            {
                biggest = number;
            }
        }

        Console.WriteLine($"The largest number is: {biggest}");
    }
}