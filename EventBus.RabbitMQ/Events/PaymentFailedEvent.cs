﻿using EventBus.RabbitMQ.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ.Events
{
    public class PaymentFailedEvent
    {
        public Guid OrderId { get; set; }
        public string Message { get; set; }
        public List<OrderItemMessage> OrderItems { get; set; }
    }
}
