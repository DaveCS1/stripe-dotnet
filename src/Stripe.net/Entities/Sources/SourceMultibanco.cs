namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
