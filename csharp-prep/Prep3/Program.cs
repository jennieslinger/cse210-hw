using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your guess? ");
        //int guess = int.Parse(Console.ReadLine());

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random RandomGenerator = new Random();
        int magicNumber = RandomGenerator.Next(1, 100);

        int guess = 0;

        while (magicNumber != guess)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess the magic number!");
            }
        }     
    }
}