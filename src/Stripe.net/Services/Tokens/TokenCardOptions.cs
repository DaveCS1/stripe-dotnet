namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenCardOptions : INestedOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}