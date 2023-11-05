public class Reflecting : Activity
{   
    private static string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you even done snything like this before?",
        "How did you get started? ",
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this expereience in mind in the future?",
    };


    public Reflecting(int duration)
        :base("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _duration = duration;
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.Clear;

        Random random = new Random();
        int PromptIndex = random.Next(prompts.Length);

        Console.WriteLine(prompts[PromptIndex]);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"----- {randomPrompt} -----"); 

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        TimeSpan durationTimeSpan = TimeSpan.FromSeconds(GetDuration);

        while ((DateTime.Now - startTime) < durationTimeSpan)
        {
            int questionIndex = random.Next(questions.Length);
            Console.WriteLine($"-----questions[questionIndex] -----");
            Thread.Sleep(5000);
        }

        base.DisplayEndingMessage();
    } 
}