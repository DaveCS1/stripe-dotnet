namespace Stripe
{
    using Newtonsoft.Json;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }
    }
}
