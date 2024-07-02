using System.Collections.Generic;

namespace ShoppingCartStore.Common.BindingModels.Order
{
    public class CreateOrderBindingModel
    {
        public CreateOrderBindingModel()
        {
            ItemIds = new List<string>();
        }

        public string FullName { get; set; }
        public string DeliveryAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string OrderNote { get; set; }

        public List<string> ItemIds { get; set; }
    }
}