public class Video
{
    private string _id;
    private string _title;
    private string _author;
    private int _length;
    private int _commentCount;
    private List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}: {_author} - {_length} - # of Comments: {_commentCount}");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment()
        }
    }
}
