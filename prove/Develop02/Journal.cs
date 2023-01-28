using System;
using System.IO;


public class Journal {

    
    public List<entry> _JournalEntry = new List<entry>();

    internal static void LoadfromFile()
    {
        throw new NotImplementedException();
    }

    public List<entry> AddEntry() {

        entry _entry = new entry.Write();

        _JournalEntry.Add(_entry);

        return _JournalEntry;
    }

    public void Display() {
        foreach (entry _entry in _JournalEntry){
            Console.WriteLine($"{_entry}");
    }

    void LoadfromFile() {

    string filename = "myJournal.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
    string[] parts = line.Split("|");

    string _date = parts[0];
    string _entry = parts[1];
    }
    }

    void SavefromFile() {

    string fileName = "myJournal.txt";

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
    foreach (entry _entry  in _JournalEntry){
    outputFile.WriteLine($"{_entry}|");
    }
    }
}
}
}
