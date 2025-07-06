using System;
using System.Collections.Generic;

public class Video
{
    private string _id;
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string id, string title, string author, int length) 
    {
	    _id = id;
	    _title = title;
	    _author = author;
	    _length = length;
    }

    public void SetComments(List<Comment> comments)
    {
	    _comments = comments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"\n{_title}: {_author} - {_length} - # of Comments: {CountComments()}");
    }

    public int CountComments()
    {
	return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}
