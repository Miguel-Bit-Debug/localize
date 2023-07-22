using Newtonsoft.Json;

namespace Localize.Domain.Models
{
    public class Billing
    {
        public Billing(bool free,
                       bool database)
        {
            Free = free;
            Database = database;
        }

        [JsonProperty("free")]
        public bool Free { get; private set; }
        [JsonProperty("database")]
        public bool Database { get; private set; }
    }
}
