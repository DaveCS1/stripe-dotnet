namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("contains")]
        public string Contains { get; set; }
    }
}
