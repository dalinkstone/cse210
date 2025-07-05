using System;
using System.Collections.Generic;

public class DataParser
{

	private List<Video> _videos = new List<Video>();

	public void SetVideos(Video video)
	{
		_videos.Add(video);
	}

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
