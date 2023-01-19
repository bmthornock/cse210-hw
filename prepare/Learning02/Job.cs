using System;

public class job 
{

    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;

    public int _endYear;

    public void Display(){
        Console.WriteLine($" {_company}, {_jobTitle} from {_startYear} to {_endYear}");
    }

}