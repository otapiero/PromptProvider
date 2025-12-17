using Microsoft.Extensions.Options;
using PromptProvider.Interfaces;
using PromptProvider.Models;
using PromptProvider.Options;

namespace PromptProvider.Services;

public class ConfigurationDefaultPromptsProvider(
    IOptions<PromptsOptions> options,
    IOptions<PromptKeyOptions> promptKeyOptions) : IDefaultPromptsProvider
{
    private readonly PromptsOptions _options = options.Value;
    private readonly PromptKeyOptions _promptKeyOptions = promptKeyOptions.Value;

    public IReadOnlyDictionary<string, string> GetDefaults()
    {
        return _options.Defaults;
    }

    public IReadOnlyDictionary<string, ChatMessage[]> GetChatDefaults()
    {
        return _options.ChatDefaults;
    }

    public IReadOnlyDictionary<string, PromptConfiguration> GetPromptKeys()
    {
        return _promptKeyOptions.PromptKeys;
    }
}
