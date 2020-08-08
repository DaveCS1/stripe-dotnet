namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerificationAdditionalDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}