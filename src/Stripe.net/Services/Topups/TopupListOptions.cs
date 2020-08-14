namespace Stripe
{
    using Newtonsoft.Json;

    public class TopupListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
