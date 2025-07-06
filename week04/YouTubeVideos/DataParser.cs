using System;
using System.Collections.Generic;

public class DataParser
{
    private List<Video> _videos = new List<Video>();

    public DataParser(List<Video> videos)
    {
        _videos = videos;
    }

    public void DisplayAll()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine()
            video.DisplayVideo();
            Console.WriteLine();
            video.DisplayComments();
        }
    }
}
