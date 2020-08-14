namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplePayDomainListOptions : ListOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
