using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

class JournalProgram
{
    static void Main(string[] args)
    {      
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string select = Console.ReadLine();

        switch (select)
        {
            case "1":
                WriteEntry();
                break;
            case "2":
                DisplayEntries();
                break;
            case "3":
                LoadEntries();
                break;
            case "4":
                SaveEntries();
                break;
            case "5":
                Console.WriteLine("Goodbye! See you next time!");
                return;
            default:
                Console.WriteLine("Invalid selection. Try again.");
                break;
        }
    }
}

public void WriteEntry()
{ 
    Console.WriteLine("Begin writting...");
    string entry = Console.ReadLine();   
}

public void DisplayEntries()
{
    string[]entries = File.ReadAllLines(journalFileName);
    Console.WriteLine("\nJournal Entries");
    foreach(string entry in entries)
    {
        Console.WriteLine(entry);
    };
}

public void LoadEntries ()
{
    if (File.Exists(journalFileName))
    {
        //
    }
    else
    {
        Console.WriteLine("No entries found");
    }
}

public void SaveEntries()
{
    if (File.Exists(journalFileName))
    {
        File.Copy(journalFileName, $"{journalFileName}.txt", true);
        Console.WriteLine("Entries saved.");
    }
    else
    {
        Console.WriteLine("No entries found to save.");
    }
}

class Program
{
    static void Main(string[]args)
    {
        JournalProgram journalProgram = new JournalProgram();
        journalProgram.Run();
    }
}
}