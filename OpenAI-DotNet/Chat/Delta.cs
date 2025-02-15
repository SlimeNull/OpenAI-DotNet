using System.Text.Json.Serialization;

namespace OpenAI.Chat
{
    public sealed class Delta
    {
        [JsonInclude]
        [JsonPropertyName("role")]
        public Role Role { get; private set; }

        [JsonInclude]
        [JsonPropertyName("content")]
        public string Content { get; private set; }
    }
}