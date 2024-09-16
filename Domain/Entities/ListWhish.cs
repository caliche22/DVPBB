using Newtonsoft.Json;

namespace Domain.Entities
{
    public class ListWhish
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("product")]
        public required Product Product { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}