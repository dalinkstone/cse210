public class Comment
{
    private string _id;
    private string _author;
    private string _content;

    public void DisplayComment()
    {
	    Console.WriteLine($"\n{_author}: {_content}")
    }
}
