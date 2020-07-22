namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the first
        /// invoice for this subscription. You may pass up to 10 items.
        /// </summary>
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account. The request must be made by a platform
        /// account on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// For new subscriptions, a past timestamp to backdate the subscription's start date to. If
        /// set, the first invoice will contain a proration for the timespan between the start date
        /// and the current time. Can be combined with trials and the billing cycle anchor.
        /// </summary>
        [JsonProperty("backdate_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? BackdateStartDate { get; set; }

        /// <summary>
        /// A future timestamp to anchor the subscription's <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</a>. This is
        /// used to determine the date of the first full invoice, and, for plans with <c>month</c>
        /// or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// Boolean indicating whether this subscription should cancel at the end of the current
        /// period.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this subscription at the end of the cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe will email your
        /// customer an invoice with payment instructions. Defaults to <c>charge_automatically</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The code of the coupon to apply to this subscription. A coupon applied to a subscription
        /// will only affect invoices created for that particular subscription.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The identifier of the customer to subscribe.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Number of days a customer has to pay invoices generated by this subscription. Valid only
        /// for subscriptions where <c>collection_method</c> is set to <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription. It must belong to the customer
        /// associated with the subscription. If not set, invoices will use the default payment
        /// method in the customer's invoice settings.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// ID of the default payment source for the subscription. It must belong to the customer
        /// associated with the subscription and be in a chargeable state. If not set, defaults to
        /// the customer's default source.
        /// </summary>
        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        public List<SubscriptionItemOptions> Items { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// Use <c>allow_incomplete</c> to create subscriptions with <c>status=incomplete</c> if the
        /// first invoice cannot be paid. Creating subscriptions with this status allows you to
        /// manage scenarios where additional user actions are needed to pay a subscription's
        /// invoice. For example, SCA regulation may require 3DS authentication to complete payment.
        /// See the <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication">SCA
        /// Migration Guide</a> for Billing to learn more. This is the default behavior.
        ///
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if a
        /// subscription's first invoice cannot be paid. For example, if a payment method requires
        /// 3DS authentication due to SCA regulation and further user action is needed, this
        /// parameter does not create a subscription and returns an error instead. This was the
        /// default behavior for API versions prior to 2019-03-14. See the <a
        /// href="https://stripe.com/docs/upgrades#2019-03-14">changelog</a> to learn more.
        ///
        /// <c>pending_if_incomplete</c> is only used with updates and cannot be passed when
        /// creating a subscription.
        /// </summary>
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to calling <a href="https://stripe.com/docs/api#create_invoice">Create an
        /// invoice</a> for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval { get; set; }

        [Obsolete("Use Items instead.")]
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The API ID of a promotion code to apply to this subscription. A promotion code applied
        /// to a subscription will only affect invoices created for that particular subscription.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// This field has been renamed to <c>proration_behavior</c>. <c>prorate=true</c> can be
        /// replaced with <c>proration_behavior=create_prorations</c> and <c>prorate=false</c> can
        /// be replaced with <c>proration_behavior=none</c>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>
        /// resulting from the <c>billing_cycle_anchor</c>. Valid values are
        /// <c>create_prorations</c> or <c>none</c>.
        ///
        /// Passing <c>create_prorations</c> will cause proration invoice items to be created when
        /// applicable. Prorations can be disabled by passing <c>none</c>. If no value is passed,
        /// the default is <c>create_prorations</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [Obsolete("Use Items instead.")]
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. This will always overwrite any trials that might apply
        /// via a subscribed plan. If set, trial_end will override the default trial period of the
        /// plan the customer is being subscribed to. The special value <c>now</c> can be provided
        /// to end the customer's trial immediately. Can be at most two years from
        /// <c>billing_cycle_anchor</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to
        /// <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not
        /// allowed.
        /// </summary>
        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. This will always overwrite any trials that might apply via a subscribed
        /// plan.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
