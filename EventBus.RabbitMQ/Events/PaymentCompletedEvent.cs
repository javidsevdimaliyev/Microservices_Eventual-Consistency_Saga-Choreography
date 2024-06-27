using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ.Events
{
    public class PaymentCompletedEvent
    {
        public Guid OrderId { get; set; }
    }
}
