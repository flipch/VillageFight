﻿namespace VillageFight.Services.Ordering.API.IntegrationEvents
{
    using System;
    using VillageFight.BuildingBlocks.EventBus.Events;

    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public OrderPaymentFailedIntegrationEvent()
        {
        }

        public OrderPaymentFailedIntegrationEvent(Guid orderId) => OrderId = orderId;
    }
}