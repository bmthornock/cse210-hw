using System;
using System.IO;


public class Journal
{


    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

        Entry myEntry = new Entry();

        myEntry.Create();

        _entries.Add(myEntry);
    }

    public void Display()
    {
        foreach (Entry _entry in _entries)
            _entry.Display();
    }

    public void LoadfromFile()
    {
        _entries.Clear();
        string filename = "myJournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _entry = parts[1];

            Entry myEntry = new Entry(_date, _entry);
            _entries.Add(myEntry);

        }
    }

    public void SaveToFile()
    {

        string fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry myEntry in _entries)
            {
                outputFile.WriteLine($"{myEntry.SavetoString()}");
            }
        }
    }
}

