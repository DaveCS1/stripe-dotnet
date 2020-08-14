namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsBitcoin : StripeEntity<ChargePaymentMethodDetailsBitcoin>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("amount_charged")]
        public long? AmountCharged { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("amount_received")]
        public long? AmountReceived { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("amount_returned")]
        public long? AmountReturned { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("refund_address")]
        public string RefundAddress { get; set; }
    }
}
