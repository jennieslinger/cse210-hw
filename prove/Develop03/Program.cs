// Scripture Memorizer
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture single = new Scripture();
        Console.WriteLine(single.GetSingleVerseTextString());

        Scripture multiverse = new Scripture();
        Console.WriteLine(multiverse.GetMultiVerseTextString());
    }
}