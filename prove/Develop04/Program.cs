using System;

class Program
{
    static void Main(string[] args)
    {
        bool activityRunning = true;
        
        while (activityRunning)
        {   Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.WriteLine("Select a choice from the menu:");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        Breathing breathingActivity = new Breathing(input);
                        breathingActivity.StartActivity();
                        break;
                    case 2:
                        Reflecting reflectingActivity = Reflecting(input);
                        reflectingActivity.StartActivity();
                        break;
                    case 3:
                        Listing listingActivity = new Listing(input);
                        listingActivity.StartActivity();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for participating today.");
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}