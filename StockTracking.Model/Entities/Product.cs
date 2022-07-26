﻿using System;
using System.Collections;

namespace StockTracking.Model.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
