namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemListOptions : ListOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
