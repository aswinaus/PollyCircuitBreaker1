using System;

namespace PricingApi.Models
{
    public class PricingDetails
    {
        public Guid ProductId { get; set; }

        public decimal Price { get; set; }

        public string CurrencyCode { get; set; }
    }
}
