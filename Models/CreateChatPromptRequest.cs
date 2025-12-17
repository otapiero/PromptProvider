namespace PromptProvider.Models;

public record CreateChatPromptRequest
{
    public required string PromptKey { get; set; }
    public required ChatMessage[] ChatMessages { get; set; }
    public string? CommitMessage { get; set; }
    public string[]? Labels { get; set; }
    public string[]? Tags { get; set; }
}
