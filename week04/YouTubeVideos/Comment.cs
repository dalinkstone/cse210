using System;
using System.Collections.Generic;

public class Comment
{
    private string _id;
    private string _author;
    private string _content;

    public Comment(string id, string author, string content)
    {
	    _id = id;
	    _author = author;
	    _content = content;
    }

    public void DisplayComment()
    {
	    Console.WriteLine($"\n{_author}: {_content}");
    }
}
