﻿using System.Text.Json.Serialization;

namespace Twitter_Sentiment_API.Models;

public class Tweets
{
    [JsonPropertyName("full_text")]
    public string? Tweet { get; set; }
    
    // [JsonPropertyName("screen_name")]
    // public int Username { get; set; }
    
    // [JsonPropertyName("created_at")]
    // public string? Date { get; set; }
    
    // [JsonPropertyName("location")]
    // public string? Location { get; set; }
    
    

}