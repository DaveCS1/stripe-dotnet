namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
