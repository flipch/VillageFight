﻿namespace Payment.API.IntegrationEvents.Events
{
    using System;
    using VillageFight.BuildingBlocks.EventBus.Events;
    using Newtonsoft.Json;

    public class OrderStatusChangedToValidatedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public decimal Total { get; set; }

        public OrderStatusChangedToValidatedIntegrationEvent()
        {
        }
    }
}