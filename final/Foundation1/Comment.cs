public class Comments{
    public string _commentAuthor;
    public string _commentText;

    public List<Video> _comments = new List<Video>();

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"\n Comment Author: {_commentAuthor}");
        Console.WriteLine($"Comment: {_commentText}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
        }
    }
}