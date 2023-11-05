public class Listing : Activity
{
    private static readonly Random random = new Random();

    private string[] questions = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public Listing( int duration)
        :base("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _duration = duration;
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.Clear();

        Random random = new Random();
        int promptIndex = random.Next(questions.Length);

        Console.WriteLine(questions[promptIndex]);

        Console.WriteLine("\nList as many responses you can to the following prompt:");

        Console.WriteLine("You may begin in: "); 
        Thread.Sleep(3000);

        int itemCount = 0;
        while (itemCount < _duration)
        {
            string listItem = Console.ReadLine();
            itemCount++;
        }
        
        Console.WriteLine($"You listed {itemCount} items!");
        base.DisplayEndingMessage();
    }
}