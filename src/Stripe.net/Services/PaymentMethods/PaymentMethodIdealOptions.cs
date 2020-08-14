namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdealOptions : INestedOptions
    {
        /// <summary>
        /// The customer's bank.
        /// Possible values:
        ///  <c>abn_amro</c>
        ///  <c>asn_bank</c>
        ///  <c>bunq</c>
        ///  <c>handelsbanken</c>
        ///  <c>ing</c>
        ///  <c>knab</c>
        ///  <c>moneyou</c>
        ///  <c>rabobank</c>
        ///  <c>regiobank</c>
        ///  <c>sns_bank</c>
        ///  <c>triodos_bank</c>
        ///  <c>van_lanschot</c>
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
