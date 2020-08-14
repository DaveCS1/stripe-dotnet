namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceGetOptions : BaseOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
