namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The customer’s address.
        /// </summary>
        [JsonProperty("address")]
        public AnyOf<AddressOptions, EmptyParam> Address { get; set; }

        /// <summary>
        /// Current balance, if any, being stored on the customer. If negative, the customer has
        /// credit to apply to their next invoice. If positive, the customer has an amount owed that
        /// will be added to their next invoice. The balance does not refer to any unpaid invoices;
        /// it solely takes into account amounts that have yet to be successfully applied to any
        /// invoice. This balance is only taken into account as invoices are finalized.
        /// </summary>
        [JsonProperty("balance")]
        public long? Balance { get; set; }

        [JsonProperty("coupon")]
        public AnyOf<string, EmptyParam> Coupon { get; set; }

        [JsonProperty("default_source")]
        public AnyOf<string, EmptyParam> DefaultSource { get; set; }

        [JsonProperty("description")]
        public AnyOf<string, EmptyParam> Description { get; set; }

        [JsonProperty("email")]
        public AnyOf<string, EmptyParam> Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public AnyOf<Dictionary<string, string>, EmptyParam> Metadata { get; set; }

        /// <summary>
        /// The customer’s full name or business name.
        /// </summary>
        [JsonProperty("name")]
        public AnyOf<string, EmptyParam> Name { get; set; }

        /// <summary>
        /// The suffix of the customer’s next invoice number.
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer’s phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer’s preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("shipping")]
        public AnyOf<ShippingOptions, EmptyParam> Shipping { get; set; }

        /// <summary>
        /// A Token’s or a Source’s ID, as returned by
        /// <a href="https://stripe.com/docs/elements">Elements</a>. Passing <c>source</c> will
        /// create a new source object, make it the new customer default source, and delete the old\
        /// customer default if one exists. If you want to add additional sources instead of
        /// replacing the existing default, use
        /// <see cref="CardService.Create(string, CardCreateOptions, RequestOptions)"/>. Whenever
        /// you attach a card to a customer, Stripe will automatically validate the card.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions, EmptyParam> Source { get; set; }

        /// <summary>
        /// Describes the customer’s tax exemption status. One of <c>none</c>,  <c>exempt</c>, or
        /// <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public AnyOf<string, EmptyParam> TaxExempt { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
