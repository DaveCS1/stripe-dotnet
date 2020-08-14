namespace Stripe
{
    using Newtonsoft.Json;

    public class FileListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
