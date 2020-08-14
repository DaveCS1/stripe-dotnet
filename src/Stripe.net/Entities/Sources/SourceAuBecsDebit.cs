namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceAuBecsDebit : StripeEntity<SourceAuBecsDebit>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
