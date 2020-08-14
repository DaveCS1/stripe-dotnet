namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBilling : StripeEntity<CardholderBilling>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
