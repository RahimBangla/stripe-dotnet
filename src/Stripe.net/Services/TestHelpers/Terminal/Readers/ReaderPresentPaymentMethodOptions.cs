// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;

    public class ReaderPresentPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Simulated data for the card_present payment method.
        /// </summary>
        [JsonProperty("card_present")]
        public ReaderCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// Simulated payment type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
