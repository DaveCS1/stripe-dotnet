namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public MandatePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of the payment method associated with this mandate. An additional hash is
        /// included on <c>payment_method_details</c> with a name matching this value. It contains
        /// mandate information specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
