﻿using System;
using System.Collections.Generic;

namespace Ntier.DAL.Entities
{
    public partial class OrderDetail
    {
        public int? OrderId { get; set; }
        public string? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
