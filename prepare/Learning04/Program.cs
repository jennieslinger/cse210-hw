using System;

class Program
{
    static void Main(string[] args)
    {
        //Create base "Assignment" object
        Assignment a1 = new Assignment("Rubble PawPatrol", "Construction");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Chase PawPatrol", "Public Safety", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Rocky PawPatrol","Reduce, Reuse, Recycle", "Pups save the Halloween Bash");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}