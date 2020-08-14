namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyAssociatedObject : StripeEntity<EphemeralKeyAssociatedObject>, IHasId
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
