﻿namespace ShoppingCartStore.Common.ViewModels.CreditCard
{
    using System;

    public class CreditCardViewModel
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string CVV { get; set; }

        public string ClientId { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
