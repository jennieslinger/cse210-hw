using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoTitle = "Why you SHOULD use imitation vanilla";
        video1._videoAuthor = "MinuteFood";
        video1._videoLength = 319;
        video1._videoComments = 750;

        Video video2 = new Video();
        video2._videoTitle = "Is Imitation Vanilla Actually Better than Real Vanilla? | What's Eating Dan?";
        video2._videoAuthor = "America's Test Kitchen";
        video2._videoLength = 727;
        video2._videoComments = 423;

        Video video3 = new Video();
        video3._videoTitle = "Tasting Expert Reveals Which Vanilla Extract is the Best";
        video3._videoAuthor = "America's Test Kitchen";
        video3._videoLength = 293;
        video3._videoComments = 937;

        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();

        video1.DisplayCommentDetails();
        video2.DisplayCommentDetails();
        video3.DisplayCommentDetails();

    }
}