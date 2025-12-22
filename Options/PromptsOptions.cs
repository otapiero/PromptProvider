using PromptProvider.Models;

namespace PromptProvider.Options;

public class PromptsOptions
{
    public Dictionary<string, string> Defaults { get; set; } = [];
    
    public Dictionary<string, ChatMessage[]> ChatDefaults { get; set; } = [];
}
