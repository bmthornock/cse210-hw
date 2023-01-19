using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        job job1 = new job();
        job1._company = "Wal-Mart";
        job1._jobTitle = "Unloader";
        job1._startYear = 2002;
        job1._endYear = 2004;

        job job2 = new job();
        job2._company = "Target";
        job2._jobTitle = "Perishable Assistant";
        job2._startYear = 2018;
        job2._endYear = 2021;

        job1.Display();
        job2.Display();

        resume resume1 = new resume();
        resume1._name = "Brenton Thornock";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();





    }
}