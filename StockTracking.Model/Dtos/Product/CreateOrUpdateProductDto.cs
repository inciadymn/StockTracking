﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Model.Dtos.Product
{
    public class CreateOrUpdateProductDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
