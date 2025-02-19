﻿using EventBus.RabbitMQ.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ.Events
{
    public class StockReservedEvent
    {
        public Guid BuyerId { get; set; }
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItemMessage> OrderItems { get; set; }
    }
}
