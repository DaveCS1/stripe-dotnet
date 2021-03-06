namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualVerificationDocument : StripeEntity<CardholderIndividualVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of a <see cref="File"/>) The back of an ID returned by a file upload with a
        /// <c>purpose</c> value of <c>identity_document</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded) The back of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        #region Expandable Front

        /// <summary>
        /// (ID of a <see cref="File"/>) The front of an ID returned by a file upload with a
        /// <c>purpose</c> value of <c>identity_document</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded) The front of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
