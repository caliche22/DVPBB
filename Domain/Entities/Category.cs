using Newtonsoft.Json;

namespace BackendC.Domain.Entities
{
    public class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }
   
        [JsonProperty("externalId")]
        public long ExternalId { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("creationAt")]
        public DateTimeOffset CreationAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
