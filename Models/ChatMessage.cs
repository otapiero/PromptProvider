using System.Text.Json.Serialization;

namespace PromptProvider.Models;

public record ChatMessage
{
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }
}
