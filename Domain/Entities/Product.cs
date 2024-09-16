using BackendC.Domain.Entities;
using Newtonsoft.Json;

namespace Domain.Entities
{
    public class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("externalId")]
        public long ExternalId { get; set; }

        [JsonProperty("title")]
        public required string Title { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public Uri[] Images { get; set; }

        [JsonProperty("creationAt")]
        public DateTimeOffset CreationAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }
}
