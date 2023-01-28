using System;

public class entry{

    public string _response;

    public string _date;

    public List<string> _newEntry = new List<string>();


    public List<string> Write(){

    _date = DateTime.Now.ToShortDateString();

    _response = Console.ReadLine();

    _newEntry.Add(_date);
    _newEntry.Add(_response);

    return _newEntry;
    }

}