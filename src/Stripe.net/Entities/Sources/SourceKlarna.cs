namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceKlarna : StripeEntity<SourceKlarna>
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("background_image_url")]
        public string BackgroundImageUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("client_token")]
        public string ClientToken { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_later_asset_urls_descriptive")]
        public string PayLaterAssetUrlsDescriptive { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_later_asset_urls_standard")]
        public string PayLaterAssetUrlsStandard { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_later_name")]
        public string PayLaterName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_later_redirect_url")]
        public string PayLaterRedirectUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_now_asset_urls_descriptive")]
        public string PayNowAssetUrlsDescriptive { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_now_asset_urls_standard")]
        public string PayNowAssetUrlsStandard { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_now_name")]
        public string PayNowName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_now_redirect_url")]
        public string PayNowRedirectUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_over_time_asset_urls_descriptive")]
        public string PayOverTimeAssetUrlsDescriptive { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_over_time_asset_urls_standard")]
        public string PayOverTimeAssetUrlsStandard { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_over_time_name")]
        public string PayOverTimeName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("pay_over_time_redirect_url")]
        public string PayOverTimeRedirectUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("payment_method_categories")]
        public string PaymentMethodCategories { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("purchase_country")]
        public string PurchaseCountry { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("purchase_type")]
        public string PurchaseType { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("shipping_delay")]
        public long ShippingDelay { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("shipping_last_name")]
        public string ShippingLastName { get; set; }
    }
}
