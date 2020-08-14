namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
