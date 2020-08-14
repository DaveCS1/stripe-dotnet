namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }
    }
}
