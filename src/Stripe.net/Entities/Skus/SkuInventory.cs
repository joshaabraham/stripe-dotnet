namespace Stripe
{
    using Newtonsoft.Json;

    public class SkuInventory : StripeEntity<SkuInventory>
    {
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
