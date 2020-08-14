namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCard : StripeEntity<SourceCard>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public string ThreeDSecure { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
