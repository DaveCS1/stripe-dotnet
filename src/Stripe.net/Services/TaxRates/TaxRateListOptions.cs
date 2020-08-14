namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
