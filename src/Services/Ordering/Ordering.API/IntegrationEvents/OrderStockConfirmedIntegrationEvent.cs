namespace VillageFight.Services.Ordering.API.IntegrationEvents
{
    using System;
    using VillageFight.BuildingBlocks.EventBus.Events;

    public class OrderStockConfirmedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public OrderStockConfirmedIntegrationEvent()
        {
        }

        public OrderStockConfirmedIntegrationEvent(Guid orderId) => OrderId = orderId;
    }
}