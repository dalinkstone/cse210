using System;
using System.Net.Http;

// to get 5 videos
// https://www.googleapis.com/youtube/v3/search?part=snippet&q=YOUR_SEARCH_QUERY&type=video&maxResults=5&key=YOUR_API_KEY
//
// to get details of the 5 videos
// https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics,contentDetails&id=VIDEO_ID1,VIDEO_ID2,VIDEO_ID3,VIDEO_ID4,VIDEO_ID5&key=YOUR_API_KEY
//
// to get 5 comments from the 5 videos
// https://www.googleapis.com/youtube/v3/commentThreads?part=snippet&videoId=VIDEO_ID&maxResults=5&key=YOUR_API_KEY

public class YouTubeApiClient
{
    private HttpClient _httpClient;
    private string _baseUrl = "https://googleapis.com/youtube/v3/";
    private string _apiKey = Environment.GetEnvironmentVariable("YOUTUBE_API_KEY");

    public YouTubeApiClient(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }

    private string BuildUrl(string endpoint, Dictionary<string, string> parameters)
    {
        string query = "";
        
	foreach (string item in parameters)
        {
            query += item.key + "=" + item.value + "&";
        }

        return _baseUrl + endpoint + "?" + query;
    }


}
