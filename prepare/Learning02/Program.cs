using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Uber";
        job1._jobTitle = "CFO";
        job1._startYear = 2010;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._company = "The Ohio State University";
        job2._jobTitle = "School Information Director";
        job2._startYear = 2014;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}