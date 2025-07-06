using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    private string _baseUrl = "https://www.googleapis.com/youtube/v3/";
    private string _apiKey = "";

    public YouTubeApiClient(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }

    private string BuildUrl(string endpoint, Dictionary<string, string> parameters)
    {
        string query = "";

        parameters["key"] = _apiKey;

        foreach (KeyValuePair<string, string> item in parameters)
        {
            query += item.Key + "=" + item.Value + "&";
        }

        return _baseUrl + endpoint + "?" + query;
    }

    private string CallApi(string endpoint, Dictionary<string, string> parameters)
    {
        string url = BuildUrl(endpoint, parameters);

        HttpResponseMessage response = _httpClient.GetAsync(url).Result;

        string json = response.Content.ReadAsStringAsync().Result;

        return json;
    }

    public List<string> GetSearchVideos()
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet",
            ["q"] = "programming",
            ["type"] = "video",
            ["maxResults"] = "5",
        };

        string response = CallApi("search", parameters);

        return ParseVideoIds(response);
    }

    // i say this later, but i really feel like this is much more verbose that it needs to be
    // im hoping there is something like custom packages availble in c# like in python where
    // someone has built out similar functionality and i can just use the wrapper
    private List<string> ParseVideoIds(string searchJson)
    {
        List<string> videoIds = new List<string>();
        JsonDocument doc = JsonDocument.Parse(searchJson);

        var items = doc.RootElement.GetProperty("items");

        // i say this later, but i can't stop thinking about enumerate and using it twice in this program
        // makes me want to do more leetcode in c++ or rust
        foreach (var item in items.EnumerateArray())
        {
            string videoId = item.GetProperty("id").GetProperty("videoId").GetString();
            videoIds.Add(videoId);
        }

        return videoIds;
    }

    private Video GetVideo(string videoId)
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet,statistics,contentDetails",
            ["id"] = videoId,
        };

        string response = CallApi("videos", parameters);

        JsonDocument doc = JsonDocument.Parse(response);

        string videoTitle = doc
            .RootElement.GetProperty("items")[0]
            .GetProperty("snippet")
            .GetProperty("title")
            .GetString();
        string videoAuthor = doc
            .RootElement.GetProperty("items")[0]
            .GetProperty("snippet")
            .GetProperty("channelTitle")
            .GetString();
        string duration = doc
            .RootElement.GetProperty("items")[0]
            .GetProperty("contentDetails")
            .GetProperty("duration")
            .GetString();

        // yes, of course i used a regex converter. i like regex101
        var regex = new Regex(@"PT(?:(\d+)H)?(?:(\d+)M)?(?:(\d+)S)?");
        var match = regex.Match(duration);

        // okay so this code is probably going to hurt your eyes and i get that, but i haven't really used
        // ternary operators too much and i would shorten these by using ternary. this gets the job done though
        int hours;
        if (match.Groups[1].Success)
        {
            hours = int.Parse(match.Groups[1].Value);
        }
        else
        {
            hours = 0;
        }

        int minutes;
        if (match.Groups[2].Success)
        {
            minutes = int.Parse(match.Groups[2].Value);
        }
        else
        {
            minutes = 0;
        }

        int seconds;
        if (match.Groups[3].Success)
        {
            seconds = int.Parse(match.Groups[3].Value);
        }
        else
        {
            seconds = 0;
        }

        int videoLength = (hours * 3600) + (minutes * 60) + seconds;

        Video newVideo = new Video(videoId, videoTitle, videoAuthor, videoLength);

        return newVideo;
    }

    public List<Video> GetVideos(List<string> videoIds)
    {
        List<Video> videos = new List<Video>();

        foreach (string videoId in videoIds)
        {
            videos.Add(GetVideo(videoId));
        }

        return videos;
    }

    private List<Comment> CallComments(string videoId)
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet",
            ["videoId"] = videoId,
            ["maxResults"] = "5",
        };

        string response = CallApi("commentThreads", parameters);

        return ParseComments(response);
    }

    private List<Comment> ParseComments(string json)
    {
        List<Comment> comments = new List<Comment>();
        JsonDocument doc = JsonDocument.Parse(json);

        var items = doc.RootElement.GetProperty("items");

        // i've been doing some leetcode recently and am incredibly happy that enumerate exists, it makes my heart warm
        foreach (var item in items.EnumerateArray())
        {
            string commentId = item.GetProperty("id").GetString();
            var snippet = item.GetProperty("snippet")
                .GetProperty("topLevelComment")
                .GetProperty("snippet");
            string commentAuthor = snippet.GetProperty("authorDisplayName").GetString();
            string commentContent = snippet.GetProperty("textDisplay").GetString();

            Comment newComment = new Comment(commentId, commentAuthor, commentContent);
            comments.Add(newComment);
        }

        return comments;
    }

    public List<Comment> GetComments(List<string> videoIds, List<Video> videos)
    {
        List<Comment> comments = new List<Comment>();

        // intuition would tell me that there is a simpler way to do this using some method on the comments list
        // but i wasnt able to find anything and didnt want to scan through documentation abyss
        for (int i = 0; i < videoIds.Count; i++)
        {
            List<Comment> videoComments = CallComments(videoIds[i]);

            // Add to the total list
            foreach (Comment comment in videoComments)
            {
                comments.Add(comment);
            }

            // Set comments on the corresponding video
            videos[i].SetComments(videoComments);
        }

        return comments;
    }
}
