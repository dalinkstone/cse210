using System;
using System.Collections.Generic;

public class DataParser
{
	private List<Video> _videos = new List<Video>();

	public DataParser(List<Video> videos)
	{
		_videos = videos;
	}

	// So I couldn't reason through using a set method here and opted to just pass in the videos
	// into the constructor. I kind of understand the trade offs here in terms of having more flexibility
	// but I felt like using a setter crosses some line of complexity

	public void DisplayAll()
	{
		foreach (Video video in _videos)
		{
			video.DisplayVideo();
			Console.WriteLine();
			Console.WriteLine(video.CountComments());
			Console.WriteLine();
			video.DisplayComments();
		}
	}

}
