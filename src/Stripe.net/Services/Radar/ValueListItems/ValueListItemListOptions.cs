namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListItemListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
