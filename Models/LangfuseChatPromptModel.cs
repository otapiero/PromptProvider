using System.Text.Json.Serialization;

namespace PromptProvider.Models;

public record LangfuseChatPromptModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("prompt")]
    public required ChatMessage[] Prompt { get; set; }

    [JsonPropertyName("config")]
    public LangfusePromptConfiguration? Config { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("labels")]
    public required string[] Labels { get; set; }

    [JsonPropertyName("tags")]
    public required string[] Tags { get; set; }
}
