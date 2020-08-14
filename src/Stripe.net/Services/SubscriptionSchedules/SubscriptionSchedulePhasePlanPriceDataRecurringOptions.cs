namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhasePlanPriceDataRecurringOptions : INestedOptions
    {
        /// <summary>
        /// Specifies billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// Possible values:
        ///  <c>day</c>
        ///  <c>month</c>
        ///  <c>week</c>
        ///  <c>year</c>
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between subscription billings. For example,
        /// <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one
        /// year interval allowed (1 year, 12 months, or 52 weeks).
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
