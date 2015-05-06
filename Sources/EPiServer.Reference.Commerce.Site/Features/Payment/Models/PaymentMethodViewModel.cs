﻿using System;
using Mediachase.Commerce;

namespace EPiServer.Reference.Commerce.Site.Features.Payment.Models
{
    public class PaymentMethodViewModel
    {
        public Guid Id { get; set; }
        public string SystemName { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public MarketId MarketId { get; set; }
        public int Ordering { get; set; }
        public bool IsDefault { get; set; }
    }
}