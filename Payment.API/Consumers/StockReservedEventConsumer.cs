using MassTransit;
using Shared.Events;

namespace Payment.API.Consumers
{
    public class StockReservedEventConsumer(IPublishEndpoint publishEndpoint) : IConsumer<StockReservedEvent>
    {
        public async Task Consume(ConsumeContext<StockReservedEvent> context)
        {
            Random random = new Random();
            bool paymentResult= random.Next(2) == 0;
            if (paymentResult)
            {
                //Payment is successful...
                PaymentCompletedEvent paymentCompletedEvent = new()
                {
                    OrderId = context.Message.OrderId
                };
                await publishEndpoint.Publish(paymentCompletedEvent);
                await Console.Out.WriteLineAsync("Payment is successful...");
            }
            else
            {
                //Payment failed...
                PaymentFailedEvent paymentFailedEvent = new()
                {
                    OrderId = context.Message.OrderId,
                    Message = "Insufficient balance...",
                    OrderItems = context.Message.OrderItems
                };
                await publishEndpoint.Publish(paymentFailedEvent);
                await Console.Out.WriteLineAsync("Payment failed...");
            }
        }
    }
}
