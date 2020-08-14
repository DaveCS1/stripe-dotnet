namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonListOptions : ListOptions
    {
        /// <summary>
        /// TODO: Field description missing from spec.
        /// </summary>
        [JsonProperty("relationship")]
        public PersonRelationshipListOptions Relationship { get; set; }
    }
}
