using System;

public class promptGenerator {

    public List<string> _randomPrompt = new List<string>();

    public string _prompt;
    Random _ranPrompt = new Random();

    public string Generate() {
        _randomPrompt.Add("Who was the most interesting person I interacted with today?");
        _randomPrompt.Add("What was the best pat of my day?");
        _randomPrompt.Add("What am I especially gratefull for today?");
        _randomPrompt.Add("If I could change one thing about my day, what would it be?");
        _randomPrompt.Add("You learn something everyday. What did I learn today?");



            int num = _ranPrompt.Next(_randomPrompt.Count);
            _prompt = _randomPrompt[num];
            return _prompt;
}
    public void Display(){
        string newPrompt = Generate();
        Console.WriteLine($"{newPrompt}");
}

}