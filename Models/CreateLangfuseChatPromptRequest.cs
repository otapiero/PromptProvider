using System.Text.Json.Serialization;

namespace PromptProvider.Models;

public record CreateLangfuseChatPromptRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("prompt")]
    public required ChatMessage[] Prompt { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("commitMessage")]
    public string? CommitMessage { get; set; }

    [JsonPropertyName("config")]
    public object? Config { get; set; }

    [JsonPropertyName("labels")]
    public string[]? Labels { get; set; }

    [JsonPropertyName("tags")]
    public string[]? Tags { get; set; }
}
