namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteListOptions : ListOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}
