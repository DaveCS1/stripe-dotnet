namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceTransformQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonProperty("divide_by")]
        public long? DivideBy { get; set; }

        /// <summary>
        /// After division, either round the result <c>up</c> or <c>down</c>.
        /// Possible values:
        ///  <c>down</c>
        ///  <c>up</c>
        /// </summary>
        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
