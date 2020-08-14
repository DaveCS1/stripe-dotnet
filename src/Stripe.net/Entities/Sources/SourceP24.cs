namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceP24 : StripeEntity<SourceP24>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
