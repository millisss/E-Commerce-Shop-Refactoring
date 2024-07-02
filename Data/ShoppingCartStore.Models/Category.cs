﻿using System.Collections.Generic;

namespace ShoppingCartStore.Models
{
    public  class Category : BaseModel
    {
        public Category()
        {
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
