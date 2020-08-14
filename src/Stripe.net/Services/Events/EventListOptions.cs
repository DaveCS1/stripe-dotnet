namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("delivery_success")]
        public bool? DeliverySuccess { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
