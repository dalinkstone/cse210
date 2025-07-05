using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	string youtubeKey = File.ReadAllText("youtube-api-key.txt").Trim();
	YouTubeApiClient client = new YouTubeApiClient(youtubeKey);

    }
}
