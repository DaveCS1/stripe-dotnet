namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceSepaCreditTransfer : StripeEntity<SourceSepaCreditTransfer>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}
