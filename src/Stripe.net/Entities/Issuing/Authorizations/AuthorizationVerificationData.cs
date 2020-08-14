namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationData : StripeEntity<AuthorizationVerificationData>
    {
        /// <summary>
        /// Whether the cardholder provided an address first line and if it matched the cardholder’s
        /// <c>billing.address.line1</c>.
        /// Possible values:
        ///  <c>match</c>
        ///  <c>mismatch</c>
        ///  <c>not_provided</c>
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Whether the cardholder provided a postal code and if it matched the cardholder’s
        /// <c>billing.address.postal_code</c>.
        /// Possible values:
        ///  <c>match</c>
        ///  <c>mismatch</c>
        ///  <c>not_provided</c>
        /// </summary>
        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// Whether the cardholder provided a CVC and if it matched Stripe’s record.
        /// Possible values:
        ///  <c>match</c>
        ///  <c>mismatch</c>
        ///  <c>not_provided</c>
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// Whether the cardholder provided an expiry date and if it matched Stripe’s record.
        /// Possible values:
        ///  <c>match</c>
        ///  <c>mismatch</c>
        ///  <c>not_provided</c>
        /// </summary>
        [JsonProperty("expiry_check")]
        public string ExpiryCheck { get; set; }
    }
}
