namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
