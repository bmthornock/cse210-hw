using System;

public class PromptGenerator
{

    public List<string> _randomPrompt = new List<string>();



    public PromptGenerator()
    {
        _randomPrompt.Add("Who was the most interesting person I interacted with today?");
        _randomPrompt.Add("What was the best pat of my day?");
        _randomPrompt.Add("What am I especially gratefull for today?");
        _randomPrompt.Add("If I could change one thing about my day, what would it be?");
        _randomPrompt.Add("You learn something everyday. What did I learn today?");
    }

    public string Generate()
    {
        Random ranPrompt = new Random();
        int num = ranPrompt.Next(_randomPrompt.Count);
        return _randomPrompt[num];

    }
    public void Display()
    {
        string newPrompt = Generate();
        Console.WriteLine($"{newPrompt}");
    }

}