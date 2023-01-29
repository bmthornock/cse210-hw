using System;

public class Entry
{

    public string _response;

    public string _date;

    public Entry(string date, string response) {

        _date = date;
        _response = response;

    }

    public Entry(){

    }

    public void Create()
    {

        _date = DateTime.Now.ToShortDateString();

        _response = Console.ReadLine();

    }

    public void Display() {

        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_response}");
    }

    public string SavetoString(){

        return _date + "|" + _response;

    }

}