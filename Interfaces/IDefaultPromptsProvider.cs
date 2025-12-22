namespace PromptProvider.Interfaces;

using PromptProvider.Models;
using PromptProvider.Options;

public interface IDefaultPromptsProvider
{
    IReadOnlyDictionary<string, string> GetDefaults();

    IReadOnlyDictionary<string, ChatMessage[]> GetChatDefaults();

    IReadOnlyDictionary<string, PromptConfiguration> GetPromptKeys();
}
