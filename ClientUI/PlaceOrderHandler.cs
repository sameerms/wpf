using Dataccess;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        static ILog Log = LogManager.GetLogger<PlaceOrderHandler>();

        public Task Handle(PlaceOrder message , IMessageHandlerContext context)
        {
            Log.Info($"Received placeorder, OrderId = {message.OrderId}");
            return Task.CompletedTask;
        }
    }
}
