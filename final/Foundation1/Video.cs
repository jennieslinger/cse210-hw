public class Video
{
    public string _videoTitle;

    public string _videoAuthor;

    public int _videoLength;

    public int _videoComments;

    public void DisplayVideoDetails()
    {   
        Console.WriteLine($"\nTitle: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Seconds: {_videoLength}");
        Console.WriteLine($"Number of Comments: {_videoComments}");
    }
}
