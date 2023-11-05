

//write out setters and getters for duration

public class Activity
{
    private string _activityName;

    private string _activityDescription;

    private int _duration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName; //
        _activityDescription = activityDescription; //
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void DisplayAnimation(int durationInSeconds, string animationMessage)
    {
        Console.WriteLine(animationMessage){"-", "\\", "|", "/"};
        for (i = 0; i < durationInSeconds; i++)
        {
            Console.Clear();
            Console.WriteLine(spinnerFrames[int % spinnerFrames.Length]);
            Thread.Sleep(500);
        }
        Console.Clear();
    }

    protected string DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity. \n This activity will help you {_activityDescription}");
        Console.WriteLine("Please enter the duration (in seconds) for this activity:");

        int inputDuration;
        int.TryParse(Console.ReadLine(), out inputDuration);
        {
            if (inputDuration >= 0)
            {
                _duration = inputDuration;
                Console.WriteLine("Get Ready...");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Try again.");
                Thread.Sleep(2000);
            }
            return $"{_activityName} coming up soon.";
        }
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! \nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        Thread.Sleep(3000);
        
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(DisplayStartingMessage());
        Console.Clear();
    }
}