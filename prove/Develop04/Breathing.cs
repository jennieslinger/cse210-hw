using System;
using System.Reflection.Metadata;
using System.Threading;

public class Breathing : Activity
{
    public Breathingy(int duration)
        :base("Breathing", "relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.")
    {
        _duration = duration;    
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.Clear();
        
        string[] breathingMessages = {"Breathe in...", "Breathe out..."};
        int messageIndex = 0;

        DateTime startTime = DateTime.Now;

        TimeSpan durationTimeSpan = TimeSpan.FromSeconds(GetDuration());

        while ((DateTime.Now - startTime ) < durationTimeSpan)
        {
            Console.WriteLine(breathingMessages[messageIndex]);
            Thread.Sleep(3000);

            messageIndex = (messageIndex +1 ) % 2; 
        }
        
        DisplayEndingMessage();
    }   
}